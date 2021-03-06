﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SundoDiary.Converter
{
    class Program
    {
        static void Main(string[] args)
        {
//            var folder = new DirectoryInfo(@"C:\Users\Andrew\Projects\SundoDiary\SundoWeb\Content\html");
            var folder = new DirectoryInfo(@"C:\Users\andrew.chaa\Documents\Projects\SundoDiary\SundoWeb\Content\html");
            var files = folder.GetFiles("*ix.htm");

            foreach (var file in files)
            {
                ExtractLinks(file);
//                Titlise(file);
//                InsertContentTag(file);
//                EncodeToUnicode(file);
//                RemoveLeadingEmptyLines(file);

            }
        }

        private static void ExtractLinks(FileInfo file)
        {
            Console.WriteLine("Extracting links from {0}", file.Name);

            IList<string> links = new List<string>();

            string content = File.ReadAllText(file.FullName);
            var linkPattern = new Regex(@"sdt[0-9]{2}_[0-9]{2}\.htm");
            string jsonFormat = 
                "    {{" + Environment.NewLine +
                "        text: \"\"," + Environment.NewLine +
                "        link: \"{0}\"" + Environment.NewLine +
                "    }}," + Environment.NewLine;

            var matches = linkPattern.Matches(content);
            foreach (var match in matches)
            {
                if (links.IndexOf(match.ToString()) == -1)
                {
                    links.Add(match.ToString());
                    File.AppendAllText(@"c:\temp\links.html", string.Format(jsonFormat, match));
                }
            }
            
        }

        private static void InsertContentTag(FileInfo file)
        {
            List<string> lines = File.ReadAllLines(file.FullName).ToList();
            lines.Insert(1, "<content>");
            lines.Add("</content>");

            File.WriteAllLines(@"c:\temp\" + file.Name, lines.ToArray(), Encoding.UTF8);
        }

        private static void Titlise(FileInfo file)
        {
            var lines = File.ReadAllLines(file.FullName).ToList();
            if (lines[0].Contains("<title></title>"))
            {
                string title = lines.Where(l => l.Contains("<b>")).First();
                lines.Remove(title);
                lines[0] = title.Replace("b", "title");
            }

            File.WriteAllLines(@"c:\temp\" + file.Name, lines, Encoding.UTF8);
        }

        private static void RemoveLeadingEmptyLines(FileInfo file)
        {
            string content = File.ReadAllText(file.FullName);
            File.WriteAllText(@"c:\temp\" + file.Name, content.TrimStart('>', ' ', '\r', '\n'), Encoding.UTF8);


        }

        private static void EncodeToUnicode(FileInfo file)
        {
            var bytes = File.ReadAllBytes(file.FullName);
            var encodedBytes = Encoding.Convert(Encoding.GetEncoding(949), Encoding.UTF8, bytes);

            File.WriteAllBytes(@"c:\temp\" + file.Name, encodedBytes);
        }
    }
}

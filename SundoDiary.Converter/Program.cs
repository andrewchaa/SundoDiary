using System;
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
            var folder = new DirectoryInfo(@"C:\Users\Andrew\Projects\SundoDiary\SundoWeb\Content\html");
            var files = folder.GetFiles();

            foreach (var file in files)
            {
                Console.WriteLine("Converting {0} ...", file.Name);
                InsertContentTag(file);
//                Titlise(file);
//                EncodeToUnicode(file);
//                RemoveLeadingEmptyLines(file);

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
            string[] lines = File.ReadAllLines(file.FullName);
            if (lines[0].Contains("<b>"))
            {
                lines[0] = lines[0].Replace("b", "title");
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

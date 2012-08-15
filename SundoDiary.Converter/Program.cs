using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SundoDiary.Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var folder = new DirectoryInfo(@"C:\Users\andrew.chaa\Documents\Projects\SundoDiary\SundoWeb\Content\html");
            var files = folder.GetFiles();

            foreach (var file in files)
            {
                Console.WriteLine("Converting {0} ...", file.Name);
                Convert(file);
            }
        }

        private static void Convert(FileInfo file)
        {
            var bytes = File.ReadAllBytes(file.FullName);
            var encodedBytes = Encoding.Convert(Encoding.GetEncoding(949), Encoding.UTF8, bytes);

            File.WriteAllBytes(@"c:\temp\" + file.Name, encodedBytes);
        }
    }
}

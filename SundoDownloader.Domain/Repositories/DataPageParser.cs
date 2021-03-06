using System;
using System.Text.RegularExpressions;

namespace SundoDiary.Domain.Repositories
{
    public class DataPageParser : IParse<DataPage>
    {
        private static readonly Regex TitleRegex = new Regex("<title>(?<title>(.|\n)*?)</title>", RegexOptions.IgnoreCase);
        private static readonly Regex ContentRegex = new Regex("<content>(?<content>(.|\n)*?)</content>", RegexOptions.IgnoreCase);

        public DataPage Parse(string content)
        {
            return new DataPage
                       {
                           Title = TitleRegex.Match(content).Groups["title"].Value.Replace(Environment.NewLine, "<br />"), 
                           Content = ContentRegex.Match(content).Groups["content"].Value.Replace(Environment.NewLine, "<br />")
                       };
        }
    }
}
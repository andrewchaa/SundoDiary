using System.Collections.Generic;

namespace SundoDiary.Domain
{
    public class DownloadedPage
    {
        public DownloadedPage()
        {
            PageUrls = new List<string>();
        }

        public string Html { get; set; }
        public IEnumerable<string> PageUrls { get; set; }
    }
}
using System.Net;

namespace SundoDiary.Domain
{
    public class Downloader
    {
        public string Page { get; private set; }

        public DownloadedPage GetIndex(string uri)
        {
            var client = new WebClient();

            try
            {
                string page = client.DownloadString(uri);
                return new DownloadedPage { Html = page };
            }
            catch(WebException exception)
            {
                return new DownloadedPage();
            }
            
        }

    }
}
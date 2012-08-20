using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace SundoDiary.Domain.Repositories
{
    public class ContentLinkRepository : IRepository<ContentLink>
    {
        private readonly string _contentDirectory;

        public ContentLinkRepository(string contentDirectory)
        {
            _contentDirectory = contentDirectory;
        }

        public IEnumerable<ContentLink> List()
        {
            string content = File.ReadAllText(Path.Combine(_contentDirectory, "contents.json"));
            var serialiser = new JavaScriptSerializer();
            var links = serialiser.Deserialize<IEnumerable<ContentLink>>(content);

            return links;
        }

        public ContentLink Get(string name)
        {
            throw new NotImplementedException();
        }
    }
}

using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SundoDiary.Domain.Repositories
{
    public class ContentRepository : IRepository<DataPage>
    {
        private readonly string _contentDirectory;
        private readonly IParse<DataPage> _parser;

        public ContentRepository(string contentDirectory, IParse<DataPage> parser)
        {
            _contentDirectory = contentDirectory;
            _parser = parser;
        }

        public DataPage Get(string name)
        {
            string content = File.ReadAllText(Path.Combine(_contentDirectory, name), Encoding.UTF8);
            return _parser.Parse(content);
        }

        public IEnumerable<DataPage> List()
        {
            throw new System.NotImplementedException();
        }
    }
}
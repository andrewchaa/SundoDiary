using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SundoDiary.Domain;

namespace SundoDiary.Models
{
    public class ReadViewModel
    {
        private LinkedList<string> _linksList;

        public ReadViewModel(IEnumerable<ContentLink> links, DataPage pageData, string currentPage)
        {
            CurrentPage = currentPage;
            PageData = pageData;
            Links = links;
            SetNavigation(links);
        }

        private void SetNavigation(IEnumerable<ContentLink> links)
        {
            _linksList = new LinkedList<string>(links.Where(l => !string.IsNullOrEmpty(l.Link)).Select(l => l.Link).ToList());
            var current = _linksList.Find(CurrentPage);
            if (current.Next != null)
                NextPage = current.Next.Value;

            if (current.Previous != null)
                PreviousPage = current.Previous.Value;
                
        }

        public string CurrentPage { get; set; }
        public DataPage PageData { get; private set; }
        public IEnumerable<ContentLink> Links { get; private set; }
        public string NextPage { get; private set; }
        public string PreviousPage { get; private set; }
    }
}
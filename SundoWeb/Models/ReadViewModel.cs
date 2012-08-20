using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SundoDiary.Domain;

namespace SundoDiary.Models
{
    public class ReadViewModel
    {
        public string PageName { get; set; }
        public DataPage DataPage { get; set; }
        public IEnumerable<ContentLink> Links { get; set; }
    }
}
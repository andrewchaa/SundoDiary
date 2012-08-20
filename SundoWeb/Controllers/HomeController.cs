using System.Web.Mvc;
using SundoDiary.Domain;
using SundoDiary.Domain.Repositories;
using SundoDiary.Models;

namespace SundoDiary.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<DataPage> _contents;
        private readonly IRepository<ContentLink> _links;

        public HomeController(IRepository<DataPage> contents, IRepository<ContentLink> links )
        {
            _contents = contents;
            _links = links;
        }

        public ActionResult Index()
        {
            return RedirectToAction("Read", "Home", new {id = "sdt00_99.htm"});
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Read(string id)
        {
            var viewModel = new ReadViewModel
                                {
                                    PageName = id,
                                    DataPage = _contents.Get(id),
                                    Links = _links.List()
                                };

            return View(viewModel);
        }
    }
}

using System.Web.Mvc;
using SundoDiary.Domain.Repositories;

namespace SundoDiary.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _contents;

        public HomeController(IRepository contents)
        {
            _contents = contents;
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
            var page = _contents.Get(id);

            return View(page);
        }
    }
}

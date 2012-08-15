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
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
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

using System.IO;
using System.Net;
using System.Text;
using System.Web.Hosting;
using System.Web.Mvc;
using SundoDiary.Domain.Repositories;

namespace SundoDiary.Controllers
{
    public class HomeController : Controller
    {
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
            string path = HostingEnvironment.MapPath("/Content/Html");
            string content = System.IO.File.ReadAllText(Path.Combine(path, id), Encoding.Default);

            var page = new DataPageParser().Parse(content);

            return View(page);
        }
    }
}

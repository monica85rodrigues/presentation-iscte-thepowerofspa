using System.Web.Mvc;

namespace MagazinesDemo.AppWithMiniSPAs.Controllers
{
    public class AuthorsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
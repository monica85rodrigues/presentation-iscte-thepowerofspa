using System.Web.Mvc;

namespace MagazinesDemo.AppWithMiniSPAs.Controllers
{
    public class MagazinesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
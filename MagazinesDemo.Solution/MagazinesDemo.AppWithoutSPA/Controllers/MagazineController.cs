using System.Web.Mvc;
using MagazinesDemo.AppWithoutSPA.DTOs;
using MagazinesDemo.AppWithoutSPA.ViewModels;
using MagazinesDemo.Business;

namespace MagazinesDemo.AppWithoutSPA.Controllers
{
    public class MagazineController : Controller
    {
        public ActionResult Index()
        {
            var magazines = BusinessManager.MagazineService.GetMagazinesByYear(2006).ToViewModel();
            return View(magazines);
        }

        public ActionResult GetMagazinesByYear(int year)
        {
            var magazines = BusinessManager.MagazineService.GetMagazinesByYear(year).ToViewModel();

            return View("Index", magazines);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new MagazineViewModel());
        }

        [HttpPost]
        public ActionResult Create(MagazineViewModel magazine)
        {
            if(!ModelState.IsValid) return View();

            BusinessManager.MagazineService.AddMagazine(magazine.ToDomainModel());

            return RedirectToAction("Index");
        }

    }
}
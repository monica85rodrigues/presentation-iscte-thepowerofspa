using System.Collections.Generic;
using System.Web.Http;
using MagazinesDemo.AppWithMiniSPAs.DTOs;
using MagazinesDemo.AppWithMiniSPAs.ViewModels;
using MagazinesDemo.Business;

namespace MagazinesDemo.AppWithMiniSPAs.ApiControllers
{
    public class MagazinesController : ApiController
    {
        public ICollection<MagazineViewModel> GetMagazines()
        {
            return BusinessManager.MagazineService.GetMagazines().ToViewModel();
        }

        public void AddMagazine(MagazineViewModel magazine)
        {
            BusinessManager.MagazineService.AddMagazine(magazine.ToDomainModel());
        }
    }
}
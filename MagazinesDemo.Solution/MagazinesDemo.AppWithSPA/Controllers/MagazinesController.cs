using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using MagazinesDemo.AppWithSPA.DTOs;
using MagazinesDemo.AppWithSPA.ViewModels;
using MagazinesDemo.Business;
using MagazinesDemo.Business.Entities;

namespace MagazinesDemo.AppWithSPA.Controllers
{
    public class MagazinesController : ApiController
    {
        public async Task<ICollection<MagazineViewModel>> GetMagazinesByYear(int year)
        {
            var magazines = await BusinessManager.MagazineService.GetMagazinesByYearAsync(year);
            return magazines.ToViewModel();
        }

        public async Task AddMagazine(Magazine magazine)
        {
            await BusinessManager.MagazineService.AddMagazineAsync(magazine);
        }
    }
}
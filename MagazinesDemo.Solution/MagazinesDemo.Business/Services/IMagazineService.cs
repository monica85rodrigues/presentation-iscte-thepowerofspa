using System.Collections.Generic;
using System.Threading.Tasks;
using MagazinesDemo.Business.Entities;

namespace MagazinesDemo.Business.Services
{
    public interface IMagazineService
    {
        ICollection<Magazine> GetMagazinesByYear(int year);

        ICollection<Magazine> GetMagazines(); 

        void AddMagazine(Magazine magazine);

        Task<ICollection<Magazine>> GetMagazinesByYearAsync(int year);

        Task AddMagazineAsync(Magazine magazine);
    }
}

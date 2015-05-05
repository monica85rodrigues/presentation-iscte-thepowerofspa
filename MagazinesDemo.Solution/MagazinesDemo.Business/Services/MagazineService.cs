using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagazinesDemo.Business.Entities;
using MagazinesDemo.Business.Repositories;

namespace MagazinesDemo.Business.Services
{
    internal class MagazineService : IMagazineService
    {
        private readonly MemoryMagazineRepository _repository = new MemoryMagazineRepository();

        public ICollection<Magazine> GetMagazinesByYear(int year)
        {
            return _repository.GetAll().Where(m => m.Year == year).ToList();
        }

        public ICollection<Magazine> GetMagazines()
        {
            return _repository.GetAll().ToList();
        }

        public void AddMagazine(Magazine magazine)
        {
            _repository.Add(magazine);
        }

        public async Task<ICollection<Magazine>> GetMagazinesByYearAsync(int year)
        {
            return await Task.Run(() => _repository.GetAll().Where(m => m.Year == year).ToList());
        }

        public async Task AddMagazineAsync(Magazine magazine)
        {
            await Task.Run(() => _repository.Add(magazine));
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using MagazinesDemo.AppWithoutSPA.ViewModels;
using MagazinesDemo.Business.Entities;

namespace MagazinesDemo.AppWithoutSPA.DTOs
{
    public static class MagazineDto
    {

        public static ICollection<MagazineViewModel> ToViewModel(this ICollection<Magazine> magazines)
        {
            return magazines.Select(m => m.ToViewModel()).ToList();
        }

        public static ICollection<Magazine> ToDomainModel(this ICollection<MagazineViewModel> magazines)
        {
            return magazines.Select(m => m.ToDomainModel()).ToList();
        } 

        public static MagazineViewModel ToViewModel(this Magazine magazine)
        {
            return new MagazineViewModel
            {
                Id = magazine.Id,
                Link = magazine.Link,
                Title = magazine.Title,
                Year = magazine.Year
            };
        }

        public static Magazine ToDomainModel(this MagazineViewModel magazine)
        {
            return new Magazine
            {
                Id = magazine.Id,
                Link = magazine.Link,
                Title = magazine.Title,
                Year = magazine.Year
            };
        }


    }
}
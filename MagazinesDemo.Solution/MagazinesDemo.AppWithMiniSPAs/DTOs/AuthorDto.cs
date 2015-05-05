using System.Collections.Generic;
using System.Linq;
using MagazinesDemo.AppWithMiniSPAs.ViewModels;
using MagazinesDemo.Business.Entities;

namespace MagazinesDemo.AppWithMiniSPAs.DTOs
{
    public static class AuthorDto
    {

        public static ICollection<AuthorViewModel> ToViewModel(this ICollection<Author> authors)
        {
            return authors.Select(m => m.ToViewModel()).ToList();
        }

        public static ICollection<Author> ToDomainModel(this ICollection<AuthorViewModel> authors)
        {
            return authors.Select(m => m.ToDomainModel()).ToList();
        }

        public static AuthorViewModel ToViewModel(this Author author)
        {
            return new AuthorViewModel
            {
                Id = author.Id,
                Name = author.Name
            };
        }

        public static Author ToDomainModel(this AuthorViewModel author)
        {
            return new Author
            {
                Id = author.Id,
                Name = author.Name
            };
        }


    }
}
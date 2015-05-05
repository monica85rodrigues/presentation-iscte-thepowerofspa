using System.Collections.Generic;
using System.Web.Http;
using MagazinesDemo.AppWithMiniSPAs.DTOs;
using MagazinesDemo.AppWithMiniSPAs.ViewModels;
using MagazinesDemo.Business;

namespace MagazinesDemo.AppWithMiniSPAs.ApiControllers
{
    public class AuthorsController : ApiController
    {
        public ICollection<AuthorViewModel> GetAuthors()
        {
            var authors = BusinessManager.AuthorService.GetAuthors().ToViewModel();
            return authors;
        }

        public void AddAuthor(AuthorViewModel author)
        {
            BusinessManager.AuthorService.AddAuthor(author.ToDomainModel());
        }
    }
}
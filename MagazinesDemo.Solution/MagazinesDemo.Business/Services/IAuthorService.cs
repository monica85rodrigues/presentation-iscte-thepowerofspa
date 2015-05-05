using System.Collections.Generic;
using MagazinesDemo.Business.Entities;

namespace MagazinesDemo.Business.Services
{
    public interface IAuthorService
    {
        ICollection<Author> GetAuthors();

        void AddAuthor(Author author);

    }
}

using System.Collections.Generic;
using System.Linq;
using MagazinesDemo.Business.Entities;
using MagazinesDemo.Business.Repositories;

namespace MagazinesDemo.Business.Services
{
    internal class AuthorService : IAuthorService
    {
        private readonly MemoryAuthorRepository _repository = new MemoryAuthorRepository();

        public ICollection<Author> GetAuthors()
        {
            return _repository.GetAll().ToList();
        }

        public void AddAuthor(Author author)
        {
            _repository.Add(author);
        }
    }
}

using System.Collections.Generic;
using MagazinesDemo.Business.Data;
using MagazinesDemo.Business.Entities;

namespace MagazinesDemo.Business.Repositories
{
    internal class MemoryAuthorRepository : IRepository<Author, int>
    {
        public static int ID = AuthorData.Authors.Count;

        public IEnumerable<Author> GetAll()
        {
            return AuthorData.Authors.Values;
        }

        public Author Get(int key)
        {
            return AuthorData.Authors.ContainsKey(key) ? AuthorData.Authors[key] : null;
        }

        public void Add(Author entity)
        {
            entity.Id = ID + 1;
            AuthorData.Authors.Add(++ID, entity);
        }

        public void Update(Author entity)
        {
            if (AuthorData.Authors.ContainsKey(entity.Id))
                AuthorData.Authors[entity.Id] = entity;
        }

        public void Remove(int key)
        {
            if (AuthorData.Authors.ContainsKey(key))
                AuthorData.Authors.Remove(key);
        }
    }
}

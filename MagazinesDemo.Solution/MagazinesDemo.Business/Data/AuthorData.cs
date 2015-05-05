using System.Collections.Generic;
using MagazinesDemo.Business.Entities;

namespace MagazinesDemo.Business.Data
{
    internal class AuthorData
    {
        public static Dictionary<int, Author> Authors = new Dictionary<int, Author>();

        static AuthorData()
        {
            Authors.Add(1, new Author{ Id = 1, Name = "Rita Peres"});
            Authors.Add(2, new Author { Id = 2, Name = "António Gonçalves" });
            Authors.Add(3, new Author { Id = 3, Name = "Nuno Cancelo" });
        }
    }
}

using System.Collections.Generic;
using Data.Models;
using Data.Abstract;
using System.Data.Entity;
using System.Linq;


namespace Data.DataBase
{
    public class AuthorRepository : IRepository<Author>
    {
        private LibraryContext db;

        public AuthorRepository(LibraryContext context)
        {
            db = new LibraryContext();
        }

        public IEnumerable<Author> List()
        {
            return db.Authors;
        }

        public Author Get(int? id)
        {
            Author author = db.Authors.Include(a => a.Books).FirstOrDefault(a => a.AuthorId == id);
            return author;
        }

        public Author GetAuthor(int id)
        {
            // Athor athor = db.Athors.FirstOrDefault(a => a.AthorId == id);
            return db.Authors.Find(id);
        }

        public Author Get(int id)
        {
            return db.Authors.Find(id);
        }

        public void Add(Author obj)
        {
            db.Authors.Add(obj);
        }

        public void Edit(Author obj)
        {
            Author author = db.Authors.Find(obj.AuthorId);
            if (author != null)
            {
                author.Name = obj.Name;
                author.Surname = obj.Surname;
                author.MiddleName = obj.MiddleName;
                author.Phone = obj.Phone;
                author.Birthday = obj.Birthday;
            }
            db.SaveChanges();
        }
    }
}

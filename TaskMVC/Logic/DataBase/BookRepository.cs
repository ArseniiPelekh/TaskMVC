using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Data.Abstract;
using Data.Models;

namespace Data.DataBase
{
    public class BookRepository : IRepository<Book>
    {
        private LibraryContext db;

        public BookRepository(LibraryContext context)
        {
            db = new LibraryContext();
        }

        public void Add(Book obj)
        {
            var at = db.Authors.FirstOrDefault(c => c.AuthorId == obj.FkAuthor);
            at.Books.Add(obj);
            db.SaveChanges();
        }

        public void Edit(Book obj)
        {
            var book = db.Books.Find(obj.BookId);
            if (book != null)
            {
                book.Name = obj.Name;
                book.Genre = obj.Genre;
                book.PageNumber = obj.PageNumber;
                book.Author = obj.Author;
            }
            db.SaveChanges();
        }

        public Book Get(int id)
        {
            return db.Books.Find(id);
        }

        public IEnumerable<Book> List()
        {
            var book = db.Books.Include(p => p.Author);
            return book;
        }
    }
}

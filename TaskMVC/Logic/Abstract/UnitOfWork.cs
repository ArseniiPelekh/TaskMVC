using System;
using Data.DataBase;

namespace Data.Abstract
{
    public class UnitOfWork : IDisposable
    {
        private LibraryContext db;
        private BookRepository bookRepository;
        private AuthorRepository authorRepository;

        public UnitOfWork() {
            db = new LibraryContext();
        }

        public BookRepository Books
        {
            get
            {
                if (bookRepository == null)
                    bookRepository = new BookRepository(db);
                return bookRepository;
            }
        }

        public AuthorRepository Authors
        {
            get
            {
                if (authorRepository == null)
                    authorRepository = new AuthorRepository(db);
                return authorRepository;
            }
        }

        public void Dispose(bool disposee)
        {
            if (disposee)
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
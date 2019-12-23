using System.Data.Entity;
using Data.Models;

namespace Data.DataBase
{
    public class LibraryContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}

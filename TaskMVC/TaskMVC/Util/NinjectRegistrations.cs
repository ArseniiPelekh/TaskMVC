using Ninject.Modules;
using Data.Abstract;
using Data.Models;
using Data.DataBase;


namespace TaskMVC.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Book>>().To<BookRepository>()
                .WithConstructorArgument("Context", new LibraryContext());
            Bind<IRepository<Author>>().To<AuthorRepository>()
                .WithConstructorArgument("Context", new LibraryContext());
        }
    }
}
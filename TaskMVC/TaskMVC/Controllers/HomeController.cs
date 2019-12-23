using System.Web.Mvc;
using Data.Abstract;
using Data.Models;

namespace TaskMVC.Controllers
{
    public class HomeController : Controller
    {

        private UnitOfWork _unitOfWork;
        public HomeController(UnitOfWork repo)
        {
            _unitOfWork = repo;
        }

        public ActionResult BooksAdd()
        {
            return PartialView(_unitOfWork.Books.List());
        }

        // GET: Home
        public ActionResult Index()
        {
            return View(_unitOfWork.Books.List());
        }
        
        public ActionResult InAuthor(int? id)
        {
            if (id == null)
                return HttpNotFound();
            if (_unitOfWork.Authors.Get(id) == null)
                return HttpNotFound();
            return View(_unitOfWork.Authors.Get(id));
        }

        public ActionResult EditAuthor(int? authorId)
        {
            if (authorId == null)
                return HttpNotFound();
            Author author = _unitOfWork.Authors.Get(authorId);
            return View(author);
        }

        [HttpPost]
        public ActionResult EditAuthor(Author author)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Authors.Edit(author);
                return RedirectToAction("Index");
            }
            else
                return View(author);
        }

    }
}
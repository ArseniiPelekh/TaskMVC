using Data.Abstract;
using Data.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace TaskMVC.Controllers
{
    public class AuthorController : ApiController
    {
        // GET: api/Author

        UnitOfWork _unitOfWork;

        public AuthorController() {
            _unitOfWork = new UnitOfWork();
        }

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Author/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Author

        public void Post(Object response)
        {
            // massive 
            JArray joResponse = JArray.Parse((string)response);
            var books = new List<Book>();
            foreach(var token in joResponse)
            {
                books.Add(new Book()
                {
                    Name = token["name"].ToString(),
                    Genre = token["genre"].ToString(),
                    PageNumber = (int)token["PageNumber"],
                    FkAuthor = (int)token["idAuthor"]
                });
            }

            for (int i = 0; i < books.Count; i++)
            {
                _unitOfWork.Books.Add(books[i]);
            }
        }

        // PUT: api/Author/5
        /*
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/Author/5
        public void Delete(int id)
        {

        }

        */
    }
}

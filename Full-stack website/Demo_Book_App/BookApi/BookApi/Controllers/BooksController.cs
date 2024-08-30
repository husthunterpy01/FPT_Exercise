using BookAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private Book[] _books = new Book[] {
            new Book(){Id = 1, Author = "John", Title = "The wish" },
            new Book(){Id = 2, Author = "Wheeljack", Title = "Tale of the nine tails" },
            new Book(){Id = 3, Author = "Anthony", Title = "The rich" },
        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return Ok(_books);
        }
    }


}

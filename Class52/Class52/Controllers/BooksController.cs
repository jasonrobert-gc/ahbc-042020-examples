using System.Collections.Generic;
using System.Linq;
using Class52.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class52.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private static List<Book> _books = new List<Book>();

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _books;
        }

        [HttpPost]
        public IActionResult Post(Book book)
        {
            _books.Add(book);
            return Created($"/api/books/{book.BookId}", book);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = _books.FirstOrDefault(x => x.BookId == id);
            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }
    }
}

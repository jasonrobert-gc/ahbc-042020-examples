using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class45_EF.Data;
using Class45_EF.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class45_EF.Controllers
{
    public class BooksManualController : Controller
    {
        private readonly LibraryContext _dbContext;

        public BooksManualController(LibraryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var books = _dbContext.Books.ToList();
            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Title", "Genre", "ReleaseData")] Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }

            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

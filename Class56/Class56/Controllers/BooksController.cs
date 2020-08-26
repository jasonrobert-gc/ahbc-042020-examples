using System.Threading.Tasks;
using Class56.Models;
using Class56.Services;
using Microsoft.AspNetCore.Mvc;

namespace Class56.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksService _service;

        public BooksController(IBooksService service)
        {
            _service = service;
        }

        // GET: Books
        public async Task<ActionResult> Index()
        {
            var model = await _service.GetAll();
            return View(model);
        }

        // GET: Books
        public async Task<Book> Details(int id)
        {
            var model = await _service.Get(id);
            return model;
        }

        // GET: Books/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Book book)
        {
            if (ModelState.IsValid)
            {
                await _service.Create(book);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }
    }
}

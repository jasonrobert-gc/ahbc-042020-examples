using Class39.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class39.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Food food)
        {
            // Save to a database??? 
            // Typically you would do something with this...
            // But for now we will just display the results

            return View(food);
        }
    }
}

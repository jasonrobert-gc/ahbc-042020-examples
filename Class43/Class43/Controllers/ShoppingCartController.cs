using Class43.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Class43.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IHttpContextAccessor _accessor;

        public ShoppingCartController(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public IActionResult Index()
        {
            var current = _accessor.HttpContext.Session.GetInt32("quantity");
            if (current == null)
            {
                current = 0;
            }

            var model = new ShoppingCart
            {
                Quantity = current.Value
            };

            return View(model);
        }

        public IActionResult Submit()
        {
            var current = _accessor.HttpContext.Session.GetInt32("quantity");
            if (current == null)
            {
                current = 0;
            }

            var newValue = current.Value + 1;
            _accessor.HttpContext.Session.SetInt32("quantity", newValue);

            return RedirectToAction("Index");
        }
    }
}

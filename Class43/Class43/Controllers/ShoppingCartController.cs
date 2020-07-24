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
            var model = new ShoppingCart
            {
                Quantity = GetQuantity()
            };

            return View(model);
        }

        public IActionResult Submit()
        {
            var newValue = GetQuantity() + 1;

            _accessor.HttpContext.Response.Cookies.Append("quantity", newValue.ToString());
            //_accessor.HttpContext.Session.SetInt32("quantity", newValue);

            return RedirectToAction("Index");
        }

        private int GetQuantity()
        {
            var current = _accessor.HttpContext.Request.Cookies["quantity"];
            //var current = _accessor.HttpContext.Session.GetInt32("quantity");

            if (!int.TryParse(current, out int value))
            {
                value = 0;
            }

            return value;
        }
    }
}

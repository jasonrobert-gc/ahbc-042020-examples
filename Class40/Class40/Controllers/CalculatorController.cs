using Class40.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class40.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index(CalculateRequest request)
        {
            return View(request);
        }

        [HttpPost]
        public IActionResult Calculate(CalculateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            // TODO - Support multiple calculation types.
            var sum = request.FirstNumber + request.SecondNumber;
            var result = new CalculateResult { Result = sum };
            return View(result);
        }
    }
}

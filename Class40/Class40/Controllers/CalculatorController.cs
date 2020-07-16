using Class40.Models;
using Class40.Services;
using Microsoft.AspNetCore.Mvc;

namespace Class40.Controllers
{
    public class CalculatorController : Controller
    {
        private IMathService _mathService;

        public CalculatorController(IMathService mathService)
        {
            _mathService = mathService;
        }

        public IActionResult Index(CalculateRequest request)
        {
            var lastRequest = _mathService.GetLastRequest();
            return View(lastRequest);
        }

        [HttpPost]
        public IActionResult Calculate(CalculateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            
            var model = _mathService.Calculate(request);

            return View(model);
        }
    }
}

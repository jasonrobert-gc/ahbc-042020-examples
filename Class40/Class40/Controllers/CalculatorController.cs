using Class40.Models;
using Class40.Services;
using Microsoft.AspNetCore.Mvc;

namespace Class40.Controllers
{
    /// <summary>
    /// SOLID - Single Responsiblity Principle (SRP) - CalculatorControl is only responsible for being a control.
    /// It facilitates web requests and providing a model to the view.
    /// </summary>
    public class CalculatorController : Controller
    {
        private IMathService _mathService;

        /// <summary>
        /// SOLID - Dependency Inversion Principle (DIP) - We invert the dependencies by breaking the direct reference
        /// to Math Service.  "Be dependent on abstractions over implementations"
        /// </summary>
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

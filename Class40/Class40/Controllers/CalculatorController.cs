using Class40.Models;
using Class40.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Class40.Controllers
{
    /// <summary>
    /// SOLID - Single Responsiblity Principle (SRP) - CalculatorControl is only responsible for being a control.
    /// It facilitates web requests and providing a model to the view.
    /// </summary>
    public class CalculatorController : Controller
    {
        private readonly IMathService _mathService;
        private readonly IHttpContextAccessor _httpContext;

        /// <summary>
        /// SOLID - Dependency Inversion Principle (DIP) - We invert the dependencies by breaking the direct reference
        /// to Math Service.  "Be dependent on abstractions over implementations"
        /// </summary>
        public CalculatorController(IMathService mathService, IHttpContextAccessor httpContext)
        {
            _mathService = mathService;
            _httpContext = httpContext;
        }

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

            // Loosely Typed  View Data
            ViewData["StartTime"] = DateTime.Now;

            // Strongly Typed Model
            var model = _mathService.Calculate(request);

            // Loosely Typed View Bag
            ViewBag.EndTime = DateTime.Now;

            // Loosely Typed Temp Data (Read Once)
            var lastRequest = $"The last request was to {request.Type} {request.FirstNumber} and {request.SecondNumber}";
            TempData["LastRequest"] = lastRequest;

            // Setting in the session to be reused
            _httpContext.HttpContext.Session.SetString("lastRequest", lastRequest);

            return View(model);
        }
    }
}

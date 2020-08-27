using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MockAssessment7.Models;
using MockAssessment7.Services;

namespace MockAssessment7.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDonutService _service;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IDonutService service, ILogger<HomeController> logger)
        {
            _service = service;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Search(int id)
        {
            var model = await _service.Get(id);
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

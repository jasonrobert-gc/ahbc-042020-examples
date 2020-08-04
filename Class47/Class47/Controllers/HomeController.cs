using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Class47.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;
using System.Runtime.InteropServices.ComTypes;

namespace Class47.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOptions<VersionOptions> _options;
        private readonly ISession _session;

        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor accessor, IOptions<VersionOptions> options)
        {
            _logger = logger;
            _options = options;
            _session = accessor.HttpContext.Session;
        }

        public IActionResult Index()
        {
            //// Ternary Operator
            // var list = _session.Keys.Any(x => x == "Cart") 
            //    ? JsonConvert.DeserializeObject<List<Book>>(_session.GetString("Cart")) 
            //    : new List<Book>();

            // Retrieving from session adding an item and saving back to session
            List<Book> list;
            if (_session.Keys.Any(x => x == "Cart"))
            {
                list = JsonConvert.DeserializeObject<List<Book>>(_session.GetString("Cart"));
            }
            else
            {
                list = new List<Book>();
            }

            list.Add(new Book(){ Title = $"Book #{DateTime.Now.Ticks}" });
            _session.SetString("Cart", JsonConvert.SerializeObject(list));

            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Version"] = _options.Value.SoftwareVersion;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

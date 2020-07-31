using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Class47.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Class47.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISession _session;

        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor accessor)
        {
            _logger = logger;
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
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

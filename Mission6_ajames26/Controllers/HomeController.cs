using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6_ajames26.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_ajames26.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bacon()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EnterMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnterMovie(Movie movie)
        {
            Console.WriteLine($"Entering movie {movie.Title}");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

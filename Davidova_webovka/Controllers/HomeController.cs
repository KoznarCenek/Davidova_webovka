using Davidova_webovka.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Davidova_webovka.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Kontakt()
        {
            return View();
        }
        public IActionResult Poptavka()
        {
            return View();
        }
        public IActionResult Dozory()
        {
            return View();
        }
        public IActionResult Projekce()
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
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UXDesignAssignment.Models;

namespace UXDesignAssignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            var saunas = SaunaData.All;

            return View(saunas);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult SaunaFinder()
        {
            var saunas = SaunaData.All;

            return View(saunas);
        }

        public IActionResult Reviews()
        {
            var saunas = SaunaData.All;

            return View(saunas);
        }

        public IActionResult FAQ()
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

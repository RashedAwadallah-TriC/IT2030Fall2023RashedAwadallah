using Microsoft.AspNetCore.Mvc;
using RashedApparel.Models;
using System.Diagnostics;

namespace RashedApparel.Controllers
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

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }


        public IActionResult Tools()
        {
            HttpContext.Session.SetString("FirstName", "Rashed");
            HttpContext.Session.SetString("LastName", "Awadallah");
            HttpContext.Session.SetString("Course", "IT2030");
            HttpContext.Session.SetString("FavNumber", "14");
            return View();
        }

        public IActionResult Tool()
        {
            HttpContext.Session.SetString("FirstName", "");
            HttpContext.Session.SetString("LastName", "");
            HttpContext.Session.SetString("Course", "");
            HttpContext.Session.SetString("FavNumber", "");
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
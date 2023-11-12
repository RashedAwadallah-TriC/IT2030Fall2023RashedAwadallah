using Microsoft.AspNetCore.Mvc;
using RashedApparel.Models;

namespace RashedApparel.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactModel contactObj)
        {
            return View(contactObj);
        }

    }
}

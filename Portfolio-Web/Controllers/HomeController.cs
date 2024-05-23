using Microsoft.AspNetCore.Mvc;
using Portfolio_Web.Models;
using System.Diagnostics;

namespace Portfolio_Web.Controllers
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
            ViewBag.lastName = "Garao";
            ViewBag.age = 22;
            var person = new Person() 
            {
                Name = "Francisco",
                LastName = "Garao",
                Age = 12,
            };
            //  es necesario especificar el nombre de la vista solamente si pasamos como model un string
            //  return View("Index", "Franchute");
            return View(person);
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

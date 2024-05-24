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
            ViewBag.age = "22";
            var projects = GetProjects().Take(2).ToList();
            var model = new HomeIndexViewModel() { Projects = projects };
            var person = new Person()
            {
                Name = "Francisco",
                LastName = "Garao",
                Age = 22,
                Address = "Calle Falsa 123"
            };
            //  es necesario especificar el nombre de la vista solamente si pasamos como model un string
            //  return View("Index", "Franchute");
            return View(model);
        }

        private List<ProjectDTO> GetProjects()
        {
            return new List<ProjectDTO>() {

                new ProjectDTO
            {
                Title = "Amazon",
                Description = "E-Commerce realizado con ASP.NET Core",
                Link = "http://link-de-prueba.com",
                ImageUrl = ""
            },
                new ProjectDTO
            {
                Title = "Amazon",
                Description = "E-Commerce realizado con ASP.NET Core",
                Link = "http://link-de-prueba.com",
                ImageUrl = ""
            },
                new ProjectDTO
            {
                Title = "Amazon",
                Description = "E-Commerce realizado con ASP.NET Core",
                Link = "http://link-de-prueba.com",
                ImageUrl = ""
            },
            };
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

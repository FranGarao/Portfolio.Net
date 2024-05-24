using Microsoft.AspNetCore.Mvc;
using Portfolio_Web.Models;
using Portfolio_Web.Services;
using System.Diagnostics;

namespace Portfolio_Web.Controllers
{
    // SingleResponsability= la clase home controller se encarga de mostrar vistas. 
    // pero ademas crea un listado de proyectos, deberia crearse una nueva clase con esta funcionalidad.
    // Igualmente, es una guia, no es necesario seguirlo a raja tabla.
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RepositoriosProyectos repositorioProyectos;

        public HomeController(ILogger<HomeController> logger, RepositoriosProyectos repositorioProyectos)
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
        }

        public IActionResult Index()
        {
            Console.WriteLine("Hola mundo!");
            ViewBag.age = "22";
            // instanciar una clase tambien es una responsabilidad. Para evitar esto podemos usar la 
            // inyeccion de dependencias.

            var projects = repositorioProyectos.GetProjects().Take(2).ToList();
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

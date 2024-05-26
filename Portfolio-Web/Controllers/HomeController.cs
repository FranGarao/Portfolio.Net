using Microsoft.AspNetCore.Mvc;
using Portfolio_Web.Models;
using Portfolio_Web.Services;
using System.Diagnostics;

namespace Portfolio_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos projectsRepository;
        private readonly TransientService transientService;
        private readonly ScopedService scopedService;
        private readonly SingletonService singletonService;
        private readonly TransientService transientService2;
        private readonly ScopedService scopedService2;
        private readonly SingletonService singletonService2;

        public HomeController(ILogger<HomeController> logger,
            IRepositorioProyectos projectsRepository,
            TransientService transientService,
            ScopedService scopedService,
            SingletonService singletonService,
            TransientService transientService2,
            ScopedService scopedService2,
            SingletonService singletonService2
            )
        {
            _logger = logger;
            this.projectsRepository = projectsRepository;
            this.transientService = transientService;
            this.scopedService = scopedService;
            this.singletonService = singletonService;
            this.transientService2 = transientService2;
            this.scopedService2 = scopedService2;
            this.singletonService2 = singletonService2;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Funciona :D");
            // trace - > debug -> information -> warning -> error -> critical
            var guidNewModel = new ExampleGUIDNewModel()

            {
                Transient = transientService.GetGuid,
                Scoped = scopedService.GetGuid,
                Singleton = singletonService.GetGuid
            };
            var guidNewModel2 = new ExampleGUIDNewModel()
            {
                Transient = transientService2.GetGuid,
                Scoped = scopedService2.GetGuid,
                Singleton = singletonService2.GetGuid
            };


            var projects = projectsRepository.GetProjects().Take(2).ToList();
            var model = new HomeIndexViewModel()
            {
                Projects = projects,
                ExampleGUID_1 = guidNewModel,
                ExampleGUID_2 = guidNewModel2
            };

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

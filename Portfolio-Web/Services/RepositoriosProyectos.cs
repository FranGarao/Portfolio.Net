using Portfolio_Web.Models;
namespace Portfolio_Web.Services
{
    public interface IRepositorioProyectos
    {
        List<ProjectDTO> GetProjects();
    }
    public class RepositoriosProyectos: IRepositorioProyectos
    {
        public List<ProjectDTO> GetProjects()
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
            },               new ProjectDTO
            {
                Title = "Amazon",
                Description = "E-Commerce realizado con ASP.NET Core",
                Link = "http://link-de-prueba.com",
                ImageUrl = ""
            },
            };
        }
    }
}

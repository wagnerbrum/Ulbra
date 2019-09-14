using Aula08CrudPeopleEF.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula08CrudPeopleEF.Controllers
{
    public class PeopleController : Controller
    {
        private IPersonRepository repository;

        public PeopleController(IPersonRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View(repository.GetAll());
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using TrabalhoG1.Models.Entities;
using TrabalhoG1.Models.Interfaces;

namespace TrabalhoG1.Controllers
{
    public class ContaLuzController : Controller
    {
        private readonly IRepository<ContaLuz> repository;

        public ContaLuzController(IRepository<ContaLuz> repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View(repository.Get());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(ContaLuz contaLuz)
        {
            repository.Insert(contaLuz);
            return RedirectToAction("Index");
        }
    }
}
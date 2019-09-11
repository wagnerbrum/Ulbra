using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using avaliacao_1.Models;

namespace avaliacao_1.Controllers
{
    public class ContaLuzController : Controller
    {
        private static ContaLuzRepository _listaContasLuz = new ContaLuzRepository();
        
        public IActionResult Index()
        {
            ContaLuzViewModel listaContasLuz = new ContaLuzViewModel(_listaContasLuz);
            
            return View(listaContasLuz);
        }

        public IActionResult Ver(int id)
        {
            return View(_listaContasLuz.GetContaLuz(id));
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}

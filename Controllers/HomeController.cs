using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Loja.Models;

namespace Loja.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Procedimentos()
        {
            return View();
        }
        public IActionResult Depoimentos(){
            return View();
        }
        public IActionResult Listagem(){
            
            List<ItemOrcamento> lista = Models.Orcamento.Listagem();
            //return View("Listagem");//retornamos  para viewe a listagem com todos os orcamentos
            return View("Orcamento");
        }
        public IActionResult Orcamento(){
            return View();
        }
[HttpPost]
        public IActionResult Cadastro(ItemOrcamento Item){
            Models.Orcamento.Incluir(Item);
            return View("Listagem"); // o objeto item que vem do formulario (view), 
            //seja incluio na classe orcamento pelo metodo incluir.
            //return RedirectToAction("Listagem", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

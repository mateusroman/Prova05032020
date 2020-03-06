using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using prova.Services;

namespace prova.Controllers
{
    public class VisualizadorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pessoas()
        {
            var sObtemPessoas = new ObtemPessoas();
            var pessoas = sObtemPessoas.ListarTodos();
            return View("~/Views/Visualizador/Pessoas.cshtml", pessoas);
        }

        public IActionResult Projetos()
        {
            return View();
        }

        public IActionResult Membros()
        {
            return View();
        }
    }
}
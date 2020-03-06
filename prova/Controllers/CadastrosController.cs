using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using prova.Services;
using prova.ViewModels;

namespace prova.Controllers
{
    public class CadastrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Projetos()
        {
            var sListaDeGerentes = new ObtemListaDeGerentes();
            var viewModel = new ProjetoViewModel()
            {
                TituloPagina = "Cadastro de Projeto",
                EstaVisualizando = false,
                GerentesSelectListItem = sListaDeGerentes.ListarTodos()
            };

            return View(viewModel);
        }

        public IActionResult Membros()
        {
            var viewModel = new MembroViewModel()
            {
                TituloPagina = "Cadastro de Membro",
                EstaVisualizando = false
            };

            return View(viewModel);
        }

        public IActionResult Pessoas()
        {
            var viewModel = new PessoaViewModel()
            {
                TituloPagina = "Cadastro de Pessoa",
                EstaVisualizando = false
            };

            return View(viewModel);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace prova.Controllers
{
    public class MembrosController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
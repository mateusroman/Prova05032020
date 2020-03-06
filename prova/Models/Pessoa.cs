using prova.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Models
{
    public class Pessoa : EntidadeBase
    {
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string CPF { get; set; }

        public bool Funcionario { get; set; }
    }
}

using prova.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Models
{
    public class Membro : EntidadeBase
    {
        public long IdPessoa { get; set; }

        public Pessoa Pessoa { get; set; }

        public long IdProjeto { get; set; }

        public Projeto Projeto { get; set; }
    }
}

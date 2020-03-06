using prova.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Models
{
    public class Projeto : EntidadeBase
    {
        public string Nome { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataPrevisaoFim { get; set; }

        public DateTime DataFim { get; set; }

        public string Descricao { get; set; }

        public string Status { get; }

        public decimal Orcamento { get; set; }

        public decimal Risco { get; set; }

        public long IdGerente { get; set; }

        public Pessoa Gerente { get; set; }

    }

    //    public enum Status : string 
    //    {
    //        EmAnalise = "Em Análise",
    //        análise realizada, 
    //        análise aprovada, 
    //        iniciado, 
    //        planejado, 
    //        em andamento, 
    //        encerrado, cancelado. 
    //    }
}

using Microsoft.AspNetCore.Mvc.Rendering;
using prova.Models;
using prova.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace prova.ViewModels
{
    public class ProjetoViewModel : ViewModelBase
    {
        public ProjetoViewModel()
        {
            DataInicio = DateTime.Today;
            DataPrevisaoFim = DateTime.Today;
            DataFim = DateTime.Today;
        }

        public long Id { get; set; }

        [Required(ErrorMessage="O nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A data de início é obrigatória")]
        public DateTime DataInicio { get; set; }

        public DateTime DataPrevisaoFim { get; set; }

        [Required(ErrorMessage = "A data de fim é obrigatória")]
        public DateTime DataFim { get; set; }

        public string Descricao { get; set; }

        public decimal? Orcamento { get; set; }

        [Required(ErrorMessage = "O status é obrigatório")]
        public string Status { get; set; }

        public decimal Risco { get; set; }

        public long IdGerente { get; set; }

        public Pessoa Gerente { get; set; }

        public List<SelectListItem> GerentesSelectListItem { get; set; }

        [Required(ErrorMessage = "O gerente é obrigatório")]
        public string GerenteSelecionado { get; set; }
    }
}

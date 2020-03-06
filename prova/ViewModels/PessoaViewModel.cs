using prova.ViewModels.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace prova.ViewModels
{
    public class PessoaViewModel : ViewModelBase
    {
        public PessoaViewModel()
        {
            DataNascimento = DateTime.Today;
        }

        public long Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O funcionário é obrigatório")]
        public bool Funcionario { get; set; }
    }
}

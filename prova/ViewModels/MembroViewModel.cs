using prova.Models;
using prova.ViewModels.Base;

namespace prova.ViewModels
{
    public class MembroViewModel : ViewModelBase
    {
        public long Id { get; set; }

        public long IdPessoa { get; set; }

        public Pessoa Pessoa { get; set; }

        public long IdProjeto { get; set; }

        public Projeto Projeto { get; set; }
    }
}

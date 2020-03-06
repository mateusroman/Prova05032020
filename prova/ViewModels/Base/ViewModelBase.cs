namespace prova.ViewModels.Base
{
    public abstract class ViewModelBase
    {
        public virtual bool EstaVisualizando { get; set; } = true;

        public virtual string TituloPagina { get; set; }

        public virtual string Excessao { get; set; }
    }
}

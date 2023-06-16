using ProjetoExercitoMVC.Models.Entity;

namespace ProjetoExercitoMVC.Models.ViewModel
{

    public class MilitarViewModel
    {
        public Militar Militar { get; set; }
        public ICollection<Companhia> Companhias { get; set; }
    }
}
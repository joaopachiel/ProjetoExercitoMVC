using ProjetoExercitoMVC.Models.Entity;
using System.ComponentModel.DataAnnotations;

namespace ProjetoExercitoMVC.Models.ViewModel
{

    public class MilitarViewModel
    {
        public Militar Militar { get; set; }

        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data de ingresso")]
        public DateTime DataIngresso { get; set; }

        [Display(Name = "Graduação")]
        public string Graduacao { get; set; }

        public Companhia Companhia { get; set; }

        [Display(Name = "Companhia")]
        public int CompanhiaId { get; set; }

        [Display(Name = "Função")]
        public string FuncaoExercida { get; set; }
        public ICollection<Companhia> Companhias { get; set; }
    }
}
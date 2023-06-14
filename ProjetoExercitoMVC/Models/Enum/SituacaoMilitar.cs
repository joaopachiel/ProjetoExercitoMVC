using System.ComponentModel.DataAnnotations;

namespace ProjetoExercitoMVC.Models.Enum
{
    public enum SituacaoMilitar
    {
        [Display(Name = "Pronto")]
        pronto,
        [Display(Name = "Férias")] 
        férias,
        [Display(Name = "Machucado")] 
        machucado 


    }
}

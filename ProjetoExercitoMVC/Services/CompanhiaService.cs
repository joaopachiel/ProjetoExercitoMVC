using ProjetoExercitoMVC.Data.Context;
using ProjetoExercitoMVC.Models.Entity;
using ProjetoExercitoMVC.Models.ViewModel;

namespace ProjetoExercitoMVC.Models.Services
{
    public class CompanhiaService
    {
        private readonly ProjetoExercitoMvcContext _context;

        public CompanhiaService(ProjetoExercitoMvcContext context)
        {
            _context = context;
        }

        //public CompanhiaFormViewModel ObterCompanhia()
        //{
        //    var companhia = new Companhia(0,null,0,null);

        //    var companhiaViewModel = new CompanhiaFormViewModel();

        //    companhiaViewModel.QuantidadeMilitares = companhia.Militares.Count();
        //}
    }
}

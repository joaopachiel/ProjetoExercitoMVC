using ProjetoExercitoMVC.Models.Entity;

namespace ProjetoExercitoMVC.Services.Interfaces
{
    public interface ICompanhiaService
    {
        List<Companhia> BuscarCompanhias();
        Companhia BuscarCompanhiaPorId(int id);
        void AdicionarCompanhia(Companhia companhia);
        void EditarCompanhia(Companhia companhia);
        void DeletarCompanhia(Companhia companhia);
    }
}

using ProjetoExercitoMVC.Models.Entity;

namespace ProjetoExercitoMVC.Services.Interfaces
{
    public interface IMilitarService
    {
        List<Militar> BuscarMilitarPorPeriodo(DateTime? dataInicio, DateTime? dataFinal);
        List<Militar> BuscarTodosMilitares();
        Militar BuscarMilitarPorId(int id);
        void AdicionarMilitar(Militar militar);
        void EditarMilitar(Militar militar);
        void DeletarMilitar(Militar militar);
    }
}

using Microsoft.EntityFrameworkCore;
using ProjetoExercitoMVC.Data.Context;
using ProjetoExercitoMVC.Models.Entity;

namespace ProjetoExercitoMVC.Services
{
    public class MilitarService
    {
        private readonly ProjetoExercitoMvcContext _context;

        public MilitarService(ProjetoExercitoMvcContext context)
        {
            _context = context;
        }

        public List<Militar> BuscarMilitarPorPeriodo(DateTime? dataInicio, DateTime? dataFinal)
        {
            var militares = from obj in _context.Militar select obj;
            if (dataInicio.HasValue)
            {
                militares = militares.Where(x => x.DataIngresso >= dataInicio.Value);
            }

            if (dataFinal.HasValue)
            {
                militares = militares.Where(x => x.DataIngresso <= dataFinal.Value);
            }

            return militares
                .OrderBy(x => x.DataIngresso)
                .ToList();
        }

        public List<Militar> BuscarTodosMilitares()
        {
            return _context.Militar.OrderBy(x => x.Nome).ToList();
        }

        public Militar BuscarMilitarPorId(int id)
        {
            return _context.Militar.Include(x => x.Companhia).FirstOrDefault(x => x.Id == id);
        }
        
        public void AdicionarMilitar(Militar militar)
        {
            _context.Add(militar);
            _context.SaveChanges();
        }

        public void EditarMilitar(Militar militar)
        {
            _context.Update(militar);
            _context.SaveChanges();
        }

        public void DeletarMilitar(Militar militar)
        {
            _context.Remove(militar);
            _context.SaveChanges();
        }
    }
}

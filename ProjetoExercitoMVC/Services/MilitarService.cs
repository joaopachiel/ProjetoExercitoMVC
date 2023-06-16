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

        public void AdicionarMilitar(Militar militar)
        {
            _context.Add(militar);
            _context.SaveChanges();
        }
    }
}

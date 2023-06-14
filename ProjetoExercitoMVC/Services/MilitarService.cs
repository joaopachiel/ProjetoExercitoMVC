using ProjetoExercitoMVC.Data.Context;

namespace ProjetoExercitoMVC.Models.Services
{
    public class MilitarService
    {
        private readonly ProjetoExercitoMvcContext _context;

        public MilitarService(ProjetoExercitoMvcContext context)
        {
            _context = context;
        }
    }
}

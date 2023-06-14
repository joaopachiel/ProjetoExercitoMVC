
using Microsoft.EntityFrameworkCore;
using ProjetoExercitoMVC.Models.Entity;

namespace ProjetoExercitoMVC.Data.Context
{
    public class ProjetoExercitoMvcContext : DbContext
    {
        public ProjetoExercitoMvcContext(DbContextOptions<ProjetoExercitoMvcContext> options) : base(options)
        {

        }
        public DbSet<Companhia> Companhia { get; set; }
        public DbSet<Militar> Militar { get; set; }
    }
}

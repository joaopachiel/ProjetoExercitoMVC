namespace ProjetoExercitoMVC.Models.Entity
{
    public class Companhia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Militar> Militares { get; set; }

        public Companhia()
        {

        }

        public Companhia(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}

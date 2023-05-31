namespace ProjetoExercitoMVC.Models
{
    public class Companhia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QtdeMilitares { get; set; }
        public ICollection<Militar> Militares { get; set; }
    }
}

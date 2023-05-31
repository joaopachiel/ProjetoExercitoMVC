namespace ProjetoExercitoMVC.Models.Entity
{
    public class Companhia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QtdeMilitares { get; set; }
        public ICollection<Militar> Militares { get; set; }

        public Companhia(int id, string nome, int qtdeMilitares, ICollection<Militar> militares)
        {
            Id = id;
            Nome = nome;
            QtdeMilitares = qtdeMilitares;
            Militares = militares;
        }
    }
}

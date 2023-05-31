using ProjetoExercitoMVC.Models.Enum;

namespace ProjetoExercitoMVC.Models
{
    public class Militar
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataIngresso { get; set; }
        public string Graduacao { get; set; }
        public Companhia Companhia { get; set; }
        public SituacaoMilitar Situacao { get; set; }

        public Militar(int id, string nome, DateTime dataIngresso, string graduacao, Companhia companhia, SituacaoMilitar situacao)
        {
            Id = id;
            Nome = nome;
            DataIngresso = dataIngresso;
            Graduacao = graduacao;
            Companhia = companhia;
            Situacao = situacao;
        }
    }
}

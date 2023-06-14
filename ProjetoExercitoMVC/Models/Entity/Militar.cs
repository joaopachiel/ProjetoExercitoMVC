using ProjetoExercitoMVC.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace ProjetoExercitoMVC.Models.Entity
{
    public class Militar
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataIngresso { get; set; }
        public string Graduacao { get; set; }
        public Companhia Companhia { get; set; }
        public ICollection<SituacaoMilitar> Situacao { get; set; } = new List<SituacaoMilitar>();
        public string FuncaoExercida { get; set; }

        public Militar(int id, string nome, DateTime dataIngresso, string graduacao, Companhia companhia, ICollection<SituacaoMilitar> situacao, string funcaoExercida)
        {
            Id = id;
            Nome = nome;
            DataIngresso = dataIngresso;
            Graduacao = graduacao;
            Companhia = companhia;
            Situacao = situacao;
            FuncaoExercida = funcaoExercida;
        }
    }
}

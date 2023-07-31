using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoExercitoMVC.Models.Entity
{
    public class Militar
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataIngresso { get; set; }
        public string Graduacao { get; set; }
        public Companhia Companhia { get; set; }
        public int CompanhiaId { get; set; }
        public string FuncaoExercida { get; set; }

        public Militar()
        {

        }

        public Militar(int id, string nome, DateTime dataIngresso, string graduacao, Companhia companhia, string funcaoExercida)
        {
            Id = id;
            Nome = nome;
            DataIngresso = dataIngresso;
            Graduacao = graduacao;
            Companhia = companhia;
            FuncaoExercida = funcaoExercida;
        }
    }
}

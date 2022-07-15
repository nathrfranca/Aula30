namespace Aula30.Models
{
    public class Aluno
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public virtual ICollection<Instituicao> Instituicoes { get; set; } = new List<Instituicao>();

    }
}

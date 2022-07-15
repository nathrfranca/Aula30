using Microsoft.EntityFrameworkCore;
namespace Aula30.Models
{
    public class ContextEscola : DbContext
    {
        public ContextEscola(DbContextOptions<ContextEscola> options)
            : base(options)
        {
        }

        public DbSet<Instituicao> Instituicoes { get; set; }
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().ToTable("Alunos").HasKey(t => t.Id);
            modelBuilder.Entity<Instituicao>().ToTable("Instituicoes").HasKey(t => t.Id);
            modelBuilder.Entity<Aluno>().HasMany(t => t.Instituicoes);
        }
    }
}

using AlunosAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AlunosAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {  }
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasData(

                new Aluno
                {
                    Id = 1,
                    Nome = "Antonio Ribeiro",
                    Email = "antonio@email.com",
                    Idade = 27
                },
                new Aluno
                {
                    Id = 2,
                    Nome = "Teste Ribeiro",
                    Email = "teste@email.com",
                    Idade = 20
                    },
                    new Aluno
                    {
                        Id = 3,
                        Nome = "Teste Junior",
                        Email = "juniore@email.com",
                        Idade = 30
                    }
                );
        }

    }
}

using AlunosAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                    }
                );
        }

    }
}

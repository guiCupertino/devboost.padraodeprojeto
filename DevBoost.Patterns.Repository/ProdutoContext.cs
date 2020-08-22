using DevBoost.Patterns.Domain.Commands;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBoost.Patterns.Repository
{
    public class ProdutoContext : DbContext
    {
        public DbSet<ProdutoCommand> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DevBoostCqrs;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProdutoCommand>().HasKey(p => p.IdProduto);
        }
    }
}

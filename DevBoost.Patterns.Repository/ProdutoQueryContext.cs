using DevBoost.Patterns.Domain.Queries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBoost.Patterns.Repository
{
    public class ProdutoQueryContext : DbContext
    {
        public DbSet<ProdutoQuery> Produtos { get; set; }

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

            modelBuilder.Entity<ProdutoQuery>().HasKey(p => p.IdProduto);            
        }

    }
}

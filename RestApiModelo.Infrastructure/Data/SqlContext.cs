using Microsoft.EntityFrameworkCore;
using RestApiModelo.Domain.Entitys;
using System;
using System.Linq;

namespace RestApiModelo.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<Passageiros> Personagem { get; set; }
        public DbSet<PersonagemParceiro> PersonagemParceiro { get; set; }
        public DbSet<Viagem> Viagem { get; set; }
        public DbSet<Parceiros> Parceiro { get; set; }
        public DbSet<Cidades> Dimensao { get; set; }
        
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
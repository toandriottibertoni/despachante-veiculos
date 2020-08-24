using App.Domain.Entidades;
using App.Domain.ObjetosDeValor;
using App.Infra.Persistencia.EF.Mapeamento;
using Microsoft.EntityFrameworkCore;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Infra.Persistencia.EF
{
    public class EfContexto : DbContext
    {
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Banco.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notification>();
            modelBuilder.Ignore<Endereco>();
            modelBuilder.Ignore<Placa>();
            modelBuilder.ApplyConfiguration(new MapPessoa());
            modelBuilder.ApplyConfiguration(new MapVeiculo());
            base.OnModelCreating(modelBuilder);
        }
    }
}

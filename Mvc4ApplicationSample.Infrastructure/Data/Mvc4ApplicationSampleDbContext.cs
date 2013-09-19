using Mvc4ApplicationSample.Domain.Models;
using Mvc4ApplicationSample.Infrastructure.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc4ApplicationSample.Infrastructure.Data
{
    public class Mvc4ApplicationSampleDbContext : DbContext
    {
        public Mvc4ApplicationSampleDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Marca> Marcas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configurando Lazy Loading
            // Configuration.LazyLoadingEnabled = false; // enabled by default

            // Removendo convenções
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            // Adicionando configurações
            modelBuilder.Configurations.Add(new UsuarioEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new CarroEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new PessoaEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new MarcaEntityTypeConfiguration());
        }
    }
}

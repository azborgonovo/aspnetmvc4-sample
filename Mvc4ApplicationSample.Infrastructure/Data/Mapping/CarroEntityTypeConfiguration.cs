using Mvc4ApplicationSample.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc4ApplicationSample.Infrastructure.Data.Mapping
{
    public class CarroEntityTypeConfiguration : EntityTypeConfiguration<Carro>
    {
        public CarroEntityTypeConfiguration()
        {
            // Tabela
            // this.ToTable("Carros", "CustomSchema");
            this.ToTable("Carros");

            // Primary Key
            this.HasKey(o => o.Id);

            // Campos
            this.Property(o => o.Modelo);

            // Relacionamentos
            this.HasRequired(o => o.Marca)
                .WithMany(o => o.Carros)
                .HasForeignKey(o => o.MarcaId);

            this.HasMany(o => o.Pessoas)
                .WithMany(o => o.Carros);
        }
    }
}

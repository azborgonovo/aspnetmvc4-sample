using Mvc4ApplicationSample.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc4ApplicationSample.Infrastructure.Data.Mapping
{
    public class PessoaEntityTypeConfiguration : EntityTypeConfiguration<Pessoa>
    {
        public PessoaEntityTypeConfiguration()
        {
            this.ToTable("Pessoas");

            this.HasKey(o => o.Id);

            this.Property(o => o.Nome);

            this.HasMany(o => o.Carros)
                .WithMany(o => o.Pessoas);
        }
    }
}

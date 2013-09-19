using Mvc4ApplicationSample.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc4ApplicationSample.Infrastructure.Data.Mapping
{
    public class MarcaEntityTypeConfiguration : EntityTypeConfiguration<Marca>
    {
        public MarcaEntityTypeConfiguration()
        {
            this.ToTable("Marcas");

            this.HasKey(o => o.Id);

            this.Property(o => o.Nome);
        }
    }
}

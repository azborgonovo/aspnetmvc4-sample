using Mvc4ApplicationSample.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc4ApplicationSample.Infrastructure.Data.Mapping
{
    public class UsuarioEntityTypeConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioEntityTypeConfiguration()
        {
            this.ToTable(SettingsHelper.UserTableName);

            this.HasKey(o => o.Id).Property(o => o.Id).HasColumnName(SettingsHelper.UserIdColumnName);

            this.Property(o => o.UserName).HasColumnName(SettingsHelper.UserNameColumnName);
        }
    }
}

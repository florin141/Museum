using Museum.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Data.Mapping
{
    public class MuseumTypeMap : EntityTypeConfiguration<MuseumType>
    {
        public MuseumTypeMap()
        {
            this.ToTable(nameof(MuseumType));
            this.HasKey(m => m.Id);

            this.Property(m => m.Name).HasMaxLength(128).IsRequired();
            this.Property(m => m.Description).IsOptional();
        }
    }
}

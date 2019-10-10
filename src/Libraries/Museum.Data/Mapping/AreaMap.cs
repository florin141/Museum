using Museum.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Data.Mapping
{
    public class AreaMap : EntityTypeConfiguration<Area>
    {
        public AreaMap()
        {
            this.ToTable(nameof(Area));
            this.HasKey(a => a.Id);

            this.Property(a => a.AreaName).HasMaxLength(128).IsRequired();
            this.Property(a => a.Zip).HasMaxLength(10).IsOptional();
            this.Property(a => a.SurfaceArea).IsOptional();
            this.Property(a => a.Population).IsRequired();

            this.HasRequired(c => c.City)
                .WithMany(a => a.Areas)
                .HasForeignKey(c => c.CityId);
        }
    }
}

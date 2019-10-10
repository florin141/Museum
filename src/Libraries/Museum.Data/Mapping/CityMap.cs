using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Museum.Core.Domain;

namespace Museum.Data.Mapping
{
    public class CityMap : EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            this.ToTable(nameof(City));
            this.HasKey(c => c.Id);

            this.Property(c => c.CityName).HasMaxLength(128).IsRequired();
            this.Property(c => c.MayorName).HasMaxLength(64).IsOptional();

            this.HasRequired(r => r.Region)
                .WithMany(c => c.Cities)
                .HasForeignKey(r => r.RegionId);
        }
    }
}

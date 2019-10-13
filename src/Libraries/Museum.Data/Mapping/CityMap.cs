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

            this.Property(c => c.Name).HasMaxLength(128).IsRequired();
            this.Property(c => c.Mayor).HasMaxLength(128).IsOptional();
            this.Property(c => c.Area).IsRequired();
            this.Property(c => c.Population).IsRequired();
            this.Property(c => c.Rank).IsOptional();
            this.Property(c => c.Density).IsOptional();
            this.Property(c => c.Website).IsOptional();

            this.HasRequired(r => r.Country)
                .WithMany(c => c.Cities)
                .HasForeignKey(c => c.CountryId);
        }
    }
}

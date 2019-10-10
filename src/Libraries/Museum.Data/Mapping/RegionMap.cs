using Museum.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Data.Mapping
{
    public class RegionMap : EntityTypeConfiguration<Region>
    {
        public RegionMap()
        {
            this.ToTable(nameof(Region));
            this.HasKey(r => r.Id);

            this.Property(r => r.RegionName).HasMaxLength(128).IsRequired();
            this.Property(r => r.President).HasMaxLength(64).IsOptional();
            this.Property(r => r.OfficialLanguage).HasMaxLength(64).IsOptional();
            this.Property(r => r.NationalDay).IsRequired();
            this.Property(r => r.Website).HasMaxLength(128).IsOptional();
            this.Property(r => r.SurfaceArea).IsRequired();
            this.Property(r => r.Population).IsRequired();

            this.HasRequired(r => r.Country)
                .WithMany(c => c.Regions)
                .HasForeignKey(c => c.CountryId);
        }
    }
}

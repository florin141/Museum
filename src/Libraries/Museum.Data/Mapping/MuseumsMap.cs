using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Museum.Core.Domain;

namespace Museum.Data.Mapping
{
    public class MuseumsMap : EntityTypeConfiguration<Museo>
    {
        public MuseumsMap()
        {
            this.ToTable("Museum");
            this.HasKey(m => m.Id);

            this.Property(m => m.Name).HasMaxLength(128).IsRequired();
            this.Property(m => m.Description).IsOptional();
            this.Property(m => m.PhoneNumber).HasMaxLength(15).IsRequired();
            this.Property(m => m.Address).HasMaxLength(64).IsRequired();
            this.Property(m => m.EmailAddress).HasMaxLength(128).IsRequired();
            this.Property(m => m.OpeningHour).IsRequired();
            this.Property(m => m.ClosingHour).IsRequired();
            this.Property(m => m.AdmissionCharge).HasColumnType("money").IsRequired();
            this.Property(m => m.Website).HasMaxLength(128).IsRequired();
            this.Property(m => m.AnnualVisitor).IsRequired();
            this.Property(m => m.BuiltDate).IsOptional();
            this.Property(m => m.Rating).IsOptional();

            this.HasRequired(c => c.City)
                .WithMany(a => a.Museums)
                .HasForeignKey(c => c.CityId);

            this.HasOptional(t => t.MuseumType)
                .WithMany(m => m.Museums)
                .HasForeignKey(m => m.MuseumTypeId);

            this.HasMany(f => f.Features)
                .WithMany(m => m.Museums)
                .Map(mf =>
                {
                    mf.MapLeftKey("MuseumId");
                    mf.MapRightKey("FeatureId");
                    mf.ToTable("MuseumFeature");
                });
        }
    }
}

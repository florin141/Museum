using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Museum.Core.Domain;

namespace Museum.Data.Mapping
{
    public class MuseumsMap : EntityTypeConfiguration<Museums>
    {
        public MuseumsMap()
        {
            this.ToTable("Museum");
            this.HasKey(m => m.Id);

            this.Property(m => m.MuseumName).HasMaxLength(128).IsRequired();
            this.Property(m => m.Description).IsOptional();
            this.Property(m => m.BuiltDate).IsRequired();
            this.Property(m => m.BecomeMuseumDate).IsOptional();
            this.Property(m => m.OpeningHour).IsOptional();
            this.Property(m => m.ClosingHour).IsOptional();
            this.Property(m => m.AnnualVisitorCount).IsRequired();
            this.Property(m => m.AdmissionCharge).HasColumnType("money").IsRequired();

            this.HasRequired(a => a.Area)
                .WithMany(m => m.Museums)
                .HasForeignKey(m => m.AreaId);

            this.HasOptional(t => t.MuseumType)
                .WithMany(m => m.Museums)
                .HasForeignKey(m => m.MuseumTypeId);

            this.HasOptional(o => o.Owner)
                .WithMany(m => m.Museums)
                .HasForeignKey(m => m.OwnerId);

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

using Museum.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Data.Mapping
{
    public class FeatureMap : EntityTypeConfiguration<Feature>
    {
        public FeatureMap()
        {
            this.ToTable(nameof(Feature));
            this.HasKey(f => f.Id);

            this.Property(f => f.FeatureName).HasMaxLength(128).IsRequired();
            this.Property(f => f.Description).IsOptional();

            this.HasRequired(t => t.FeatureType)
                .WithMany(f => f.Features)
                .HasForeignKey(f => f.FeatureTypeId);
        }
    }
}

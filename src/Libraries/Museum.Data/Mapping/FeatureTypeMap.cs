using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Museum.Core.Domain;

namespace Museum.Data.Mapping
{
    public class FeatureTypeMap : EntityTypeConfiguration<FeatureType>
    {
        public FeatureTypeMap()
        {
            this.ToTable(nameof(FeatureType));
            this.HasKey(ft => ft.Id);

            this.Property(ft => ft.FeatureTypeName).HasMaxLength(128).IsRequired();
        }
    }
}

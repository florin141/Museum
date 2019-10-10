using Museum.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Data.Mapping
{
    public class OwnerMap : EntityTypeConfiguration<Owner>
    {
        public OwnerMap()
        {
            this.ToTable(nameof(Owner));
            this.HasKey(o => o.Id);

            this.Property(o => o.FirstName).HasMaxLength(64).IsRequired();
            this.Property(o => o.MiddleName).HasMaxLength(64).IsOptional();
            this.Property(o => o.LastName).HasMaxLength(64).IsRequired();
            this.Property(o => o.DateOfBirth).IsOptional();
            this.Property(o => o.Email).HasMaxLength(128).IsRequired();
            this.Property(o => o.Nationality).HasMaxLength(64).IsRequired();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Museum.Core.Domain;

namespace Museum.Data.Mapping
{
    public class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            this.ToTable(nameof(Country));
            this.HasKey(c => c.Id);

            this.Property(c => c.CountryName).HasMaxLength(128).IsRequired();
            this.Property(c => c.CountryCode).HasMaxLength(5).IsRequired();
            this.Property(c => c.DialingCode).HasMaxLength(4);
            this.Property(c => c.Currency).HasMaxLength(10).IsRequired();
            this.Property(c => c.DrivingSide).IsOptional();
            this.Property(c => c.Flag).IsOptional();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Core.Domain
{
    public class Country : BaseEntity
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string DialingCode { get; set; }
        public string Currency { get; set; }
        public DrivingSide DrivingSide { get; set; }
        public byte[] Flag { get; set; }

        public ICollection<Region> Regions { get; set; }
    }
}

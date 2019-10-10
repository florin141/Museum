using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Core.Domain
{
    public class Region : BaseEntity
    {
        public string RegionName { get; set; }
        public string President { get; set; }
        public string OfficialLanguage { get; set; }
        public DateTime NationalDay { get; set; }
        public string Website { get; set; }
        public float SurfaceArea { get; set; }
        public int Population { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}

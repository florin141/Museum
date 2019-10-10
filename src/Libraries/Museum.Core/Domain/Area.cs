using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Core.Domain
{
    public class Area : BaseEntity
    {
        public string AreaName { get; set; }
        public string Zip { get; set; }
        public float SurfaceArea { get; set; }
        public int Population { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public ICollection<Museums> Museums { get; set; }
    }
}

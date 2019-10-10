using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Core.Domain
{
    public class City : BaseEntity
    {
        public string CityName { get; set; }
        public string MayorName { get; set; }

        public int RegionId { get; set; }
        public Region Region { get; set; }

        public ICollection<Area> Areas { get; set; }
    }
}

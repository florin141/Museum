using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Core.Domain
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public string Mayor { get; set; }
        public float Area { get; set; }
        public int Population { get; set; }
        public int Rank { get; set; }
        public int Density { get; set; }
        public string Website { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public ICollection<Museums> Museums { get; set; }
    }
}

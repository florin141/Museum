using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Museum.Api.Models
{
    public class CityDto
    {
        public string Name { get; set; }
        public string Mayor { get; set; }
        public float Area { get; set; }
        public int Population { get; set; }
        public int Rank { get; set; }
        public int Density { get; set; }
        public string Website { get; set; }
    }
}
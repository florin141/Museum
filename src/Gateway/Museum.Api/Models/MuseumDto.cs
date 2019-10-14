using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Museum.Api.Models
{
    public class MuseumDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string OpeningHours { get; set; }
        public decimal AdmissionCharge { get; set; }
        public string Website { get; set; }
        public int AnnualVisitor { get; set; }
        public DateTime BuiltDate { get; set; }
        public byte Rating { get; set; }

        public ICollection<FeatureDto> Features { get; set; }
    }
}
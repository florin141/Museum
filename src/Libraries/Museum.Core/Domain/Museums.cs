using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Core.Domain
{
    // ToDo: Fix class name conflict with namespace name
    public class Museums : BaseEntity
    {
        public string MuseumName { get; set; }
        public string Description { get; set; }
        public DateTime BuiltDate { get; set; }
        public DateTime BecomeMuseumDate { get; set; }
        public byte OpeningHour { get; set; }
        public byte ClosingHour { get; set; }
        public int AnnualVisitorCount { get; set; }
        public decimal AdmissionCharge { get; set; }

        public int AreaId { get; set; }
        public Area Area { get; set; }

        public int? MuseumTypeId { get; set; }
        public MuseumType MuseumType { get; set; }

        public ICollection<Feature> Features { get; set; }

        public int? OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}

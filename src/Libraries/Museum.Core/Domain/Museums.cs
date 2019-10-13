using System;
using System.Collections.Generic;

namespace Museum.Core.Domain
{
    // ToDo: Fix class name conflict with namespace name
    public class Museums : BaseEntity
    {
        /// <summary>
        /// Museum name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Museum description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Museum address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Weekday open hour
        /// </summary>
        public byte OpeningHour { get; set; }

        /// <summary>
        /// Weekday closing hour
        /// </summary>
        public byte ClosingHour { get; set; }

        /// <summary>
        /// Admission charge
        /// </summary>
        public decimal AdmissionCharge { get; set; }

        /// <summary>
        /// Museum official website
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// Annual visitors
        /// </summary>
        public int AnnualVisitor { get; set; }

        /// <summary>
        /// Museum built data
        /// </summary>
        public DateTime BuiltDate { get; set; }

        /// <summary>
        /// Rating
        /// </summary>
        public byte Rating { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public int? MuseumTypeId { get; set; }
        public MuseumType MuseumType { get; set; }

        public ICollection<Feature> Features { get; set; }
    }
}

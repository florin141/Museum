using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Core.Domain
{
    /// <summary>
    /// Country 
    /// </summary>
    public class Country : BaseEntity
    {
        /// <summary>
        /// Country name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Capital
        /// </summary>
        public string Capital { get; set; }

        /// <summary>
        /// Official language
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Country code
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Calling code
        /// </summary>
        public string DialingCode { get; set; }

        /// <summary>
        /// Driving side
        /// </summary>
        public DrivingSide DrivingSide { get; set; }

        /// <summary>
        /// Official currency
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Gross domestic product
        /// </summary>
        public long GDP { get; set; }

        /// <summary>
        /// Flag
        /// </summary>
        public byte[] Flag { get; set; }

        /// <summary>
        /// Cities
        /// </summary>
        public ICollection<City> Cities { get; set; }
    }
}

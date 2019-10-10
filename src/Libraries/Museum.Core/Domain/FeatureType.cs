using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Core.Domain
{
    public class FeatureType : BaseEntity
    {
        public string FeatureTypeName { get; set; }

        public ICollection<Feature> Features { get; set; }
    }
}

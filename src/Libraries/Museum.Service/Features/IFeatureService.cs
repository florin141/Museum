using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Museum.Core.Domain;

namespace Museum.Service.Features
{
    public interface IFeatureService
    {
        Feature GetFeatureById(int featureId);
        IEnumerable<Feature> GetAllFeatures();
        void Insert(Feature feature);
        void Insert(IEnumerable<Feature> features);
        void Update(Feature feature);
        void Update(IEnumerable<Feature> features);
        void Delete(Feature feature);
        void Delete(IEnumerable<Feature> features);
    }
}

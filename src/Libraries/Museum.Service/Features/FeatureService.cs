using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Museum.Core.Data;
using Museum.Core.Domain;

namespace Museum.Service.Features
{
    public class FeatureService : IFeatureService
    {
        private readonly IRepository<Feature> _featureRepository;

        public FeatureService(IRepository<Feature> featureRepository)
        {
            _featureRepository = featureRepository;
        }

        public Feature GetFeatureById(int featureId)
        {
            if (featureId <= 0)
                return null;

            return _featureRepository.GetById(featureId);
        }

        public IEnumerable<Feature> GetAllFeatures()
        {
            return _featureRepository.GetAll();
        }

        public void Insert(Feature feature)
        {
            if (feature == null)
                throw new ArgumentNullException(nameof(feature));

            _featureRepository.Insert(feature);

            // log
        }

        public void Insert(IEnumerable<Feature> features)
        {
            if (features == null)
                throw new ArgumentNullException(nameof(features));

            _featureRepository.Insert(features);

            // log
        }

        public void Update(Feature feature)
        {
            if (feature == null)
                throw new ArgumentNullException(nameof(feature));

            _featureRepository.Update(feature);

            // log
        }

        public void Update(IEnumerable<Feature> features)
        {
            if (features == null)
                throw new ArgumentNullException(nameof(features));

            _featureRepository.Update(features);

            // log
        }

        public void Delete(Feature feature)
        {
            if (feature == null)
                throw new ArgumentNullException(nameof(feature));

            _featureRepository.Delete(feature);

            // log
        }

        public void Delete(IEnumerable<Feature> features)
        {
            if (features == null)
                throw new ArgumentNullException(nameof(features));

            _featureRepository.Delete(features);

            // log
        }
    }
}

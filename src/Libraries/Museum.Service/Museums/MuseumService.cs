using System;
using System.Collections.Generic;
using System.Linq;
using Museum.Core.Data;
using Museum.Core.Domain;

namespace Museum.Service.Museums
{
    public class MuseumService : IMuseumService
    {
        private readonly IRepository<Museo> _museumRepository;
        private readonly IRepository<Feature> _featureRepository;

        public MuseumService(IRepository<Museo> museumRepository, 
            IRepository<Feature> featureRepository)
        {
            _museumRepository = museumRepository;
            _featureRepository = featureRepository;
        }

        public Museo GetMuseumById(int museumId)
        {
            if (museumId <= 0)
                return null;



            var query = _museumRepository.Table
                .SingleOrDefault(m => m.Features.Any(f => f.Id == museumId));

            var result = query;

            return result;
        }

        public IEnumerable<Museo> GetAllMuseums(string cityName = null, string countryName = null, string featureName = null, string ownerName = null, string museumType = null)
        {
            var query = _museumRepository.Table;

            if (!string.IsNullOrWhiteSpace(cityName))
                query = query.Where(m => m.City.Name == cityName);

            return query.ToList();
        }

        public void Insert(Museo museum)
        {
            if (museum == null)
                throw new ArgumentNullException(nameof(museum));

            _museumRepository.Insert(museum);

            // log
        }

        public void Insert(IEnumerable<Museo> museums)
        {
            if (museums == null)
                throw new ArgumentNullException(nameof(museums));

            _museumRepository.Insert(museums);

            // log
        }

        public void Update(Museo museum)
        {
            if (museum == null)
                throw new ArgumentNullException(nameof(museum));

            _museumRepository.Update(museum);

            // log
        }

        public void Update(IEnumerable<Museo> museums)
        {
            if (museums == null)
                throw new ArgumentNullException(nameof(museums));

            _museumRepository.Update(museums);

            // log
        }

        public void Delete(Museo museum)
        {
            if (museum == null)
                throw new ArgumentNullException(nameof(museum));

            _museumRepository.Delete(museum);

            // log
        }

        public void Delete(IEnumerable<Museo> museums)
        {
            if (museums == null)
                throw new ArgumentNullException(nameof(museums));

            _museumRepository.Delete(museums);

            // log
        }
    }
}

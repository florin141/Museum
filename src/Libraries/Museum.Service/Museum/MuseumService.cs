using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Museum.Core.Data;
using Museum.Core.Domain;

namespace Museum.Service.Museum
{
    public class MuseumService : IMuseumService
    {
        private readonly IRepository<Museums> _museumRepository;

        public MuseumService(IRepository<Museums> museumRepository)
        {
            _museumRepository = museumRepository;
        }

        public IEnumerable<Museums> GetAllMuseums(string cityName = null, string countryName = null, string featureName = null, string ownerName = null, string museumType = null)
        {
            var query = _museumRepository.Table;

            if (!string.IsNullOrWhiteSpace(cityName))
                query = query.Where(m => m.City.Name == cityName);

            if (!string.IsNullOrWhiteSpace(countryName))
            {
                
            }

            return query.ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Museum.Core.Data;
using Museum.Core.Domain;

namespace Museum.Service.Cities
{
    public class CityService : ICityService
    {
        private readonly IRepository<City> _cityRepository;

        public CityService(IRepository<City> cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public City GetCityById(int cityId)
        {
            if (cityId <= 0)
                return null;

            return _cityRepository.GetById(cityId);
        }

        public IEnumerable<City> GetAllCities()
        {
            return _cityRepository.GetAll();
        }

        public void Insert(City city)
        {
            if (city == null)
                throw new ArgumentNullException(nameof(city));

            _cityRepository.Insert(city);

            // log
        }

        public void Insert(IEnumerable<City> cities)
        {
            if (cities == null)
                throw new ArgumentNullException(nameof(cities));

            _cityRepository.Insert(cities);

            // log
        }

        public void Update(City city)
        {
            if (city == null)
                throw new ArgumentNullException(nameof(city));

            _cityRepository.Update(city);

            // log
        }

        public void Update(IEnumerable<City> cities)
        {
            if (cities == null)
                throw new ArgumentNullException(nameof(cities));

            _cityRepository.Update(cities);

            // log
        }

        public void Delete(City city)
        {
            if (city == null)
                throw new ArgumentNullException(nameof(city));

            _cityRepository.Delete(city);

            // log
        }

        public void Delete(IEnumerable<City> cities)
        {
            if (cities == null)
                throw new ArgumentNullException(nameof(cities));

            _cityRepository.Delete(cities);

            // log
        }
    }
}

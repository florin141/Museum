using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Museum.Core.Data;
using Museum.Core.Domain;

namespace Museum.Service.Countries
{
    public class CountryService : ICountryService
    {
        private readonly IRepository<Country> _countryRepository;

        public CountryService(IRepository<Country> countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public Country GetCountryById(int countryId)
        {
            if (countryId <= 0)
                return null;

            return _countryRepository.GetById(countryId);
        }

        public IEnumerable<Country> GetAllCountries()
        {
            return _countryRepository.GetAll();
        }

        public void Insert(Country country)
        {
            if (country == null)
                throw new ArgumentNullException(nameof(country));

            _countryRepository.Insert(country);

            // log
        }

        public void Insert(IEnumerable<Country> countries)
        {
            if (countries == null)
                throw new ArgumentNullException(nameof(countries));

            _countryRepository.Insert(countries);

            // log
        }

        public void Update(Country country)
        {
            if (country == null)
                throw new ArgumentNullException(nameof(country));

            _countryRepository.Update(country);

            // log
        }

        public void Update(IEnumerable<Country> countries)
        {
            if (countries == null)
                throw new ArgumentNullException(nameof(countries));

            _countryRepository.Update(countries);

            // log
        }

        public void Delete(Country country)
        {
            if (country == null)
                throw new ArgumentNullException(nameof(country));

            _countryRepository.Delete(country);

            // logs
        }

        public void Delete(IEnumerable<Country> countries)
        {
            if (countries == null)
                throw new ArgumentNullException(nameof(countries));

            _countryRepository.Delete(countries);

            // log
        }
    }
}

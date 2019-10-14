using Museum.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Service.Countries
{
    public interface ICountryService
    {
        Country GetCountryById(int countryId);
        IEnumerable<Country> GetAllCountries();
        void Insert(Country country);
        void Insert(IEnumerable<Country> countries);
        void Update(Country country);
        void Update(IEnumerable<Country> countries);
        void Delete(Country country);
        void Delete(IEnumerable<Country> countries);
    }
}

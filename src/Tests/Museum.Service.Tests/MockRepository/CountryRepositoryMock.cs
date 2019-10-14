using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Museum.Core.Data;
using Museum.Core.Domain;
using Museum.Service.Tests.Stubs;

namespace Museum.Service.Tests.MockRepository
{
    public class CountryRepositoryMock
    {
        public Mock<IRepository<Country>> CountryRepository { get; set; }

        public CountryRepositoryMock()
        {
            CountryRepository = new Mock<IRepository<Country>>();

            CountryRepository.Setup(x => x.GetAll()).Returns(CountryStub.GetCountries);
            CountryRepository.Setup(x => x.GetById(1)).Returns(CountryStub.Country1);
        }
    }
}

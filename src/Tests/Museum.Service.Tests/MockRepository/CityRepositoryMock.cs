using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Museum.Core.Data;
using Museum.Core.Domain;
using Museum.Service.Tests.Stubs;

namespace Museum.Service.Tests.MockRepository
{
    public class CityRepositoryMock
    {
        public Mock<IRepository<City>> CityRepository { get; set; }

        public CityRepositoryMock()
        {
            CityRepository = new Mock<IRepository<City>>();

            CityRepository.Setup(x => x.GetAll()).Returns(CityStub.GetCities);
            CityRepository.Setup(x => x.GetById(It.IsAny<int>())).Returns(CityStub.City1);
            CityRepository.Setup(x => x.Delete(It.IsAny<City>()));
        }
    }
}

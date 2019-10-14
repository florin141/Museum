using System;
using System.Collections.Generic;
using System.Text;
using Museum.Core.Domain;

namespace Museum.Service.Tests.Stubs
{
    public static class CityStub
    {
        public static City City1 = new City
        {
            Id = 1,
            Name = "Madrid",
            Mayor = "Jose Luis Martinez-Almeida",
            Area = 604.3f,
            Population = 3223334,
            Rank = 1,
            Density = 5333,
            Website = "https://www.madrid.es",
            CountryId = 1
        };

        public static City City2 = new City
        {
            Id = 2,
            Name = "Barcelona",
            Mayor = "Ada Colau Ballano",
            Area = 101.4f,
            Population = 1620343,
            Rank = 2,
            Density = 15979,
            Website = "https://www.barcelona.es",
            CountryId = 1
        };

        public static City City3 = new City
        {
            Id = 3,
            Name = "Valencia",
            Mayor = "Joan Ribo i Canut",
            Area = 134.64f,
            Population = 791413,
            Rank = 3,
            Density = 5877,
            Website = "https://www.valencia.es",
            CountryId = 1
        };

        public static City City4 = new City
        {
            Id = 4,
            Name = "Seville",
            Mayor = "Juan Espadas",
            Area = 140f,
            Population = 688711,
            Rank = 4,
            Density = 4919,
            Website = "https://www.sevilla.es",
            CountryId = 1
        };

        public static City City5 = new City
        {
            Id = 5,
            Name = "Zaragoza",
            Mayor = "Jorge Azcon",
            Area = 973.78f,
            Population = 666880,
            Rank = 5,
            Density = 680,
            Website = "https://www.zaragoza.es",
            CountryId = 1
        };

        public static City City6 = new City
        {
            Id = 6,
            Name = "Paris",
            Mayor = "Anne Hidalgo",
            Area = 105.4f,
            Population = 2140526,
            Rank = 1,
            Density = 20308,
            Website = "https://www.paris.fr",
            CountryId = 2
        };

        public static City City7 = new City
        {
            Id = 7,
            Name = "Marseille",
            Mayor = "Jean-Claude Gaudin",
            Area = 240.62f,
            Population = 855393,
            Rank = 2,
            Density = 3554,
            Website = "https://www.marseille.fr",
            CountryId = 2
        };

        public static City City8 = new City
        {
            Id = 8,
            Name = "Lyon",
            Mayor = "Gerard Collomb",
            Area = 47.87f,
            Population = 513275,
            Rank = 3,
            Density = 10722,
            Website = "https://www.lyon.fr",
            CountryId = 2
        };

        public static City City9 = new City
        {
            Id = 9,
            Name = "Toulouse",
            Mayor = "Jean-Luc Moudenc",
            Area = 118.3f,
            Population = 458298,
            Rank = 4,
            Density = 3874,
            Website = "https://www.toulouse.fr",
            CountryId = 2
        };

        public static City City10 = new City
        {
            Id = 10,
            Name = "Nice",
            Mayor = "Christian Estrosi",
            Area = 71.92f,
            Population = 342295,
            Rank = 5,
            Density = 4759,
            Website = "https://www.nice.fr",
            CountryId = 2
        };

        public static City City11 = new City
        {
            Id = 11,
            Name = "London",
            Mayor = "Sadiq Khan",
            Area = 1572,
            Population = 8908081,
            Rank = 1,
            Density = 5666,
            Website = "https://www.london.uk",
            CountryId = 3
        };

        public static City City12 = new City
        {
            Id = 12,
            Name = "Manchester",
            Mayor = "Abid Latif Chohan",
            Area = 115.6f,
            Population = 547627,
            Rank = 2,
            Density = 4131,
            Website = "https://www.manchester.uk",
            CountryId = 3
        };

        public static City City13 = new City
        {
            Id = 13,
            Name = "Liverpool",
            Mayor = "Joe Anderson",
            Area = 111.8f,
            Population = 494814,
            Rank = 3,
            Density = 4425,
            Website = "https://www.liverpool.uk",
            CountryId = 3
        };

        public static City City14 = new City
        {
            Id = 14,
            Name = "Cambridge",
            Mayor = "Gerri Bird",
            Area = 40.7f,
            Population = 125758,
            Rank = 4,
            Density = 3089,
            Website = "https://www.cambridge.uk",
            CountryId = 3
        };

        public static City City15 = new City
        {
            Id = 15,
            Name = "Oxford",
            Mayor = "Cllr Colin Cook",
            Area = 45.59f,
            Population = 154600,
            Rank = 5,
            Density = 3391,
            Website = "https://www.oxford.uk",
            CountryId = 3
        };

        public static IEnumerable<City> GetCities = new List<City>(collection: new[]
        {
            City1,
            City2,
            City3,
            City4,
            City5,
            City6,
            City6,
            City7,
            City8,
            City9,
            City10,
            City11,
            City12,
            City13,
            City14,
            City15
        });
    }
}

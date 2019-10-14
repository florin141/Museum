using System;
using System.Collections.Generic;
using System.Text;
using Museum.Core.Domain;

namespace Museum.Service.Tests.Stubs
{
    public static class CountryStub
    {
        public static Country Country1 = new Country
        {
            Id = 1,
            Name = "Spain",
            Capital = "Madrid",
            Language = "Spanish",
            CountryCode = "ES",
            DialingCode = "+34",
            DrivingSide = DrivingSide.Right,
            Currency = "EUR",
            GDP = 1946000000000
        };

        public static Country Country2 = new Country
        {
            Id = 2,
            Name = "France",
            Capital = "Paris",
            Language = "French",
            CountryCode = "FR",
            DialingCode = "+33",
            DrivingSide = DrivingSide.Right,
            Currency = "EUR",
            GDP = 3081000000000
        };

        public static Country Country3 = new Country
        {
            Id = 3,
            Name = "United Kingdom",
            Capital = "London",
            Language = "English",
            CountryCode = "UK",
            DialingCode = "+44",
            DrivingSide = DrivingSide.Left,
            Currency = "GBP",
            GDP = 3128000000000
        };

        public static IEnumerable<Country> GetCountries = new List<Country>(collection: new[]
        {
            Country1,
            Country2,
            Country3
        });
    }
}

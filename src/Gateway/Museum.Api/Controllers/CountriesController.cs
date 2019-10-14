using AutoMapper;
using Museum.Api.Models;
using Museum.Service.Countries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Museum.Api.Controllers
{
    [RoutePrefix("api/countries")]
    public class CountriesController : ApiController
    {
        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;

        public CountriesController(ICountryService countryService, IMapper mapper)
        {
            _countryService = countryService;
            _mapper = mapper;
        }

        [Route()]
        public IHttpActionResult Get()
        {
            try
            {
                var countries = _countryService.GetAllCountries();

                if (countries == null)
                {
                    return NotFound();
                }

                return Ok(_mapper.Map<IEnumerable<CountryDto>>(countries));
            }
            catch
            {
                // ToDo Add Logging
                return InternalServerError();
            }
        }
    }
}
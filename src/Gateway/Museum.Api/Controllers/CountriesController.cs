using AutoMapper;
using Museum.Api.Models;
using Museum.Core.Domain;
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

        [Route("{id}", Name = "GetCountry")]
        public IHttpActionResult Get(int id)
        {
            try
            {
                var country = _countryService.GetCountryById(id);

                if (country == null)
                {
                    return NotFound();
                }

                return Ok(_mapper.Map<CountryDto>(country));
            }
            catch
            {
                // ToDo Add Logging
                return InternalServerError();
            }
        }

        [Route()]
        public IHttpActionResult Post(CountryDto model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var country = _mapper.Map<Country>(model);
                    _countryService.Insert(country);

                    return CreatedAtRoute("GetCountry", new { id = country.Id }, country);
                }
            }
            catch
            {
                // ToDo Add Logging
                return InternalServerError();
            }

            return BadRequest(ModelState);
        }

        [Route("{id}")]
        public IHttpActionResult Put(int id, CountryDto model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var country = _countryService.GetCountryById(id);
                    if (country == null)
                        return NotFound();

                    var newCountry = _mapper.Map(model, country);
                    _countryService.Update(newCountry);

                    return Ok(_mapper.Map<CountryDto>(newCountry));
                }
            }
            catch
            {
                // ToDo Add Logging
                return InternalServerError();
            }

            return BadRequest(ModelState);
        }

        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var country = _countryService.GetCountryById(id);

                if (country == null)
                    return NotFound();

                _countryService.Delete(country);

                return Ok();
            }
            catch
            {
                return InternalServerError();
            }
        }
    }
}
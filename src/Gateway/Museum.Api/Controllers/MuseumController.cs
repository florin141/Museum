using AutoMapper;
using Museum.Api.Models;
using Museum.Core.Domain;
using Museum.Service.Museums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Museum.Api.Controllers
{
    [RoutePrefix("api/museums")]
    public class MuseumsController : ApiController
    {
        private readonly IMuseumService _museumService;
        private readonly IMapper _mapper;

        public MuseumsController(IMuseumService museumService, IMapper mapper)
        {
            _museumService = museumService;
            _mapper = mapper;
        }

        [Route()]
        public IHttpActionResult Get()
        {
            try
            {
                //return Ok(_mapper.Map<IEnumerable<MuseumDto>>(_museumService.GetAllMuseums()));
                var result = _museumService.GetMuseumById(1);

                if (result == null)
                {
                    return NotFound();
                }


                return Ok(_mapper.Map<MuseumDto>(result));
            }
            catch
            {
                // ToDo Add Logging
                return InternalServerError();
            }
        }

        [Route("{id}")]
        public IHttpActionResult Get(int id)
        {
            try
            {
                var result = _museumService.GetMuseumById(id);

                if (result == null) {
                    return NotFound();
                }


                return Ok(_mapper.Map<MuseumDto>(result));
            }
            catch
            {
                // ToDo Add Logging
                return InternalServerError();
            }
        }
    }
}
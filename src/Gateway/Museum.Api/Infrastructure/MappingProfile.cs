using AutoMapper;
using Museum.Api.Models;
using Museum.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Museum.Api.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateCitiesMaps();
            CreateCountriesMaps();
            CreateFeatureMaps();
            CreateMuseumMaps();
            CreateMuseumTypeMaps();
        }

        protected void CreateCitiesMaps()
        {
            CreateMap<City, CityDto>().ReverseMap();
        }

        protected void CreateCountriesMaps()
        {
            CreateMap<Country, CountryDto>().ReverseMap();
        }

        protected void CreateFeatureMaps()
        {
            CreateMap<Feature, FeatureDto>().ReverseMap();
        }

        protected void CreateMuseumMaps()
        {
            CreateMap<Museo, MuseumDto>()
                .ForMember(c => c.OpeningHours, opt => opt.MapFrom(m => m.OpeningHour + " a.m. - " + m.ClosingHour + " p.m.")).ReverseMap();
        }

        protected void CreateMuseumTypeMaps()
        {
            CreateMap<MuseumType, MuseumTypeDto>().ReverseMap();
        }
    }
}
using FluentValidation.Attributes;
using Museum.Api.Validators;
using Museum.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Museum.Api.Models
{
    [Validator(typeof(CountryValidator))]
    public class CountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Language { get; set; }
        public string CountryCode { get; set; }
        public string DialingCode { get; set; }
        public DrivingSide DrivingSide { get; set; }
        public string Currency { get; set; }
        public long GDP { get; set; }
    }
}
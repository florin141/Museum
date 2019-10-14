using FluentValidation;
using Museum.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Museum.Api.Validators
{
    public class CountryValidator : AbstractValidator<CountryDto>
    {
        public CountryValidator()
        {
            RuleFor(x => x.Name).MaximumLength(128).NotEmpty();
            RuleFor(x => x.Capital).MaximumLength(128).NotEmpty();
            RuleFor(x => x.Language).MaximumLength(128).NotEmpty();
            RuleFor(x => x.CountryCode).MaximumLength(5).NotEmpty();
            RuleFor(x => x.DialingCode).MaximumLength(4);
            RuleFor(x => x.Currency).MaximumLength(10).NotEmpty();
            RuleFor(x => x.GDP).GreaterThan(0);
        }
    }
}
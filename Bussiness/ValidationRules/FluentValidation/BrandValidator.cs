using System;
using System.Collections.Generic;
using Entities.Concrete;
using FluentValidation;
using System.Text;

namespace Bussiness.ValidationRules.FluentValidation
{
    public class BrandValidator:AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.BrandName).NotEmpty();
            RuleFor(b => b.BrandName).MinimumLength(2);
        }
    }
}

using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImages>
    {
        public CarImageValidator()
        {
            RuleFor(p => p.CarId).NotEmpty();
            
        }
    }
}


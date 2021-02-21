using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CustomerName).NotEmpty();
            RuleFor(c => c.CustomerName).MinimumLength(5);
            RuleFor(c => c.UserId).NotEmpty();
        }
    }
}

﻿using FluentValidation;
using MvcWebUi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUi.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator : AbstractValidator<ShippingDetail>
    {

        public ShippingDetailValidator()
        {
            RuleFor(s=>s.FirstName).NotEmpty().WithMessage("First Name is Required baby!");
            RuleFor(s => s.FirstName).MinimumLength(2);
            RuleFor(s => s.LastName).NotEmpty();
            RuleFor(s => s.Address).NotEmpty();
            RuleFor(s => s.City).NotEmpty().When(s => s.Age < 18);
          //  RuleFor(s => s.FirstName).Must(StartWithA);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}

using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.CarName).Must(StartWhithA).WithMessage("Ürünler A harfi ile başlamalıdır");
        }

        private bool StartWhithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}

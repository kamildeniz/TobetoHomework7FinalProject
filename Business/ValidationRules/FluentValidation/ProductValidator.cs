using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).MinimumLength(2).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p=>p.CategoryID==1);
            RuleFor(p => p.ProductName).Must(StarWithA).WithMessage("Ürünler A harfi ile başlamalıdır.");
        }

        private bool StarWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}

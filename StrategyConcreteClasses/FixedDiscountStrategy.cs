using InterfaceDiscount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyConcreteClasses
{
    public class FixedDiscountStrategy : IDiscountStrategy
    {
        private static readonly decimal _fixedDiscount = 20;

        public decimal ApplyDiscount(decimal price)
        {
            return price - (price * _fixedDiscount / 100);
        }
    }
}

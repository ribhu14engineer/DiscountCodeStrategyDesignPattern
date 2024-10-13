using InterfaceDiscount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyConcreteClasses
{
    public class PercentageDiscountStrategy : IDiscountStrategy
    {
        private readonly decimal _percentDiscount;
        public PercentageDiscountStrategy(decimal percentDiscount)
        {
            _percentDiscount = percentDiscount;
        }

        public decimal ApplyDiscount(decimal price)
        {
            return price - (price * _percentDiscount / 100);
        }
    }
}

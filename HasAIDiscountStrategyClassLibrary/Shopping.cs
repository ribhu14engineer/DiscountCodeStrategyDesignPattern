using InterfaceDiscount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasAIDiscountStrategyClassLibrary
{
    public class Shopping
    {
        private IDiscountStrategy _discountStrategy;

        public void setDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal calculatePrice(decimal price)
        {
            return _discountStrategy.ApplyDiscount(price);
        }
    }
}

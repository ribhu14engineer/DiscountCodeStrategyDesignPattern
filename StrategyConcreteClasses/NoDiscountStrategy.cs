using InterfaceDiscount;

namespace StrategyConcreteClasses
{
    public class NoDiscountStrategy : IDiscountStrategy
    {

        public decimal ApplyDiscount(decimal price)
        {
            return price;
        }
    }
}

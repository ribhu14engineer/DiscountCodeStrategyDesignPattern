using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDiscount
{
    public interface IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price);
    }
}

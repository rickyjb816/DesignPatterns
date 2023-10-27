using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shared.Patterns.FactoryPattern {
    public interface IDiscountPolicy {

        decimal GetDiscount(decimal value);
    }
}

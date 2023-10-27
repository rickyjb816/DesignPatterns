using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shared.Patterns.FactoryPattern {
    public class IrregularDiscount : IDiscountPolicy {
        public decimal GetDiscount(decimal value) {
            return value * 0.5m;
        }
    }
}

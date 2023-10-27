using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatterns.Shared.Enums;

namespace DesignPatterns.Shared.Patterns.FactoryPattern {
    public interface IDiscountFactory {
        IDiscountPolicy ApplyPolicy(DiscountType discountType);

        decimal ApplyDiscount();
    }
}

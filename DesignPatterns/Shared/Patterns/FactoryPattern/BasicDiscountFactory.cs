using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatterns.Shared.Enums;

namespace DesignPatterns.Shared.Patterns.FactoryPattern {
    public class BasicDiscountFactory : IDiscountFactory {

        private IDiscountPolicy _policy;
        private readonly decimal _value;

        public BasicDiscountFactory(decimal value) {
            _value = value;
        }

        public BasicDiscountFactory(DiscountType type, decimal value) {
            _value = value;
            _policy = ApplyPolicy(type);
        }

        public decimal ApplyDiscount() {
            return _policy.GetDiscount(_value);
        }

        public IDiscountPolicy ApplyPolicy(DiscountType discountType) {
            switch (discountType) {
                case DiscountType.Normal:
                    _policy = new NormalDiscount();
                    break;
                case DiscountType.Irregular:
                    _policy =  new IrregularDiscount();
                    break;
                default:
                    return null;
            }
            return _policy;
        }
    }
}

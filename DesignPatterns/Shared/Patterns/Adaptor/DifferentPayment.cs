using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shared.Patterns.Adaptor {
    public class DifferentPayment {
        public string ProcessPayment(decimal amount) {
            return $"You paid £{amount}";
        }
    }
}

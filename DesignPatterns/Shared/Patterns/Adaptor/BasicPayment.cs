using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shared.Patterns.Adaptor {
    public class BasicPayment : IPaymentProcess {
        public string Display() {
            throw new NotImplementedException();
        }

        public string ProcessPayment(decimal amount, string recipent) {
            return $"You send £{amount} to {recipent}";
        }
    }
}

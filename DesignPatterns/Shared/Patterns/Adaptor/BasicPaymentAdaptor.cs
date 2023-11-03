using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shared.Patterns.Adaptor {
    public class BasicPaymentAdaptor : IPaymentProcess {

        private readonly DifferentPayment differentPayment;

        public BasicPaymentAdaptor(DifferentPayment differentPayment) {
            this.differentPayment = differentPayment;
        }

        public string Display() {
            throw new NotImplementedException();
        }

        public string ProcessPayment(decimal amount, string recipent) {
            string value = "";

            value = differentPayment.ProcessPayment(amount);
            value += $" to {recipent}";

            return value;
        }
    }
}

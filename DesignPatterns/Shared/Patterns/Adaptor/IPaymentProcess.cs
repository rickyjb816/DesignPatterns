using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shared.Patterns.Adaptor {
    public interface IPaymentProcess {
        public string ProcessPayment(decimal amount, string recipent);
    }
}

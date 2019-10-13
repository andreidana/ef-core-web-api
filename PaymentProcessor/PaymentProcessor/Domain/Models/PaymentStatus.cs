using PaymentProcessor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentProcessor.Domain.Models
{
    public class PaymentStatus
    {
        public PaymentDTO payment { get; set; }
        public Status status { get; set; }
    }
}

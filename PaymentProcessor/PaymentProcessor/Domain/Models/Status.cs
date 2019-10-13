using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentProcessor.Domain.Models
{
    public enum Status
    {
        PENDING = 1,
        PROCESSED = 2,
        FAILED = 3
    }
}

using PaymentProcessor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentProcessor.Domain.Services
{
    public interface IPaymentsService
    {

        Task<Payment> ProcessAsync(Payment payment);
    }
}

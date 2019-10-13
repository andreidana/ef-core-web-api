using Microsoft.EntityFrameworkCore;
using PaymentProcessor.Domain.Entities;

namespace PaymentProcessor
{
    public class PaymentContext: DbContext
    {
        public DbSet<Payment> Payments { get; set; }
        public PaymentContext(DbContextOptions<PaymentContext> options): base(options)
        {
        }
    }
}

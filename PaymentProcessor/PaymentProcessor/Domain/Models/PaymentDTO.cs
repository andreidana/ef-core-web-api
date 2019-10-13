using System;

namespace PaymentProcessor.Models
{
    public class PaymentDTO
    {
        public String CCN { get; set; }
        public String CardHolder { get; set; }
        public DateTime ExpirationDate { get; set; }
        public String SecurityCode { get; set; }
        public Decimal Amount { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;


namespace PaymentProcessor.Domain.Entities
{
    public class Payment
    {
        public int ID { get; set; }
        [Required]
        public String CCN { get; set; }
        [Required]
        public String CardHolder { get; set; }
        public DateTime ExpirationDate { get; set; }
        public String SecurityCode { get; set; }
        [Required]
        public Decimal Amount { get; set; }
    }
}

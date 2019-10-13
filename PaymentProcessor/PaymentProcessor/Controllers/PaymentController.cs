using Microsoft.AspNetCore.Mvc;
using PaymentProcessor.Domain.Services;
using PaymentProcessor.Models;

namespace PaymentProcessor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentsService _paymentsService;

        public PaymentController(IPaymentsService paymentsService)
        {
            _paymentsService = paymentsService;
        }

        [HttpPost]
        public void Post([FromBody] PaymentDTO reqBody)
        {
            //var processedPayment = await _paymentsService.ProcessAsync(reqBody);
        }
    }
}

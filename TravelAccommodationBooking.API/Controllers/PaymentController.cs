using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelAccommodationBooking.Dtos.Error;
using TravelAccommodationBooking.Services.Interfaces;
using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.API.Controllers;

[Route("payments")]
[ApiController]
[Authorize]
public class PaymentController : ControllerBase
{
    private readonly IPaymentService _paymentService;

    public PaymentController(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    // POST /payments/{bookingId}
    [HttpPost]
    public async Task<IActionResult> ProcessPayment([FromBody] Payment payment)
    {
        try
        {
            var processedPayment = await _paymentService.ProcessPaymentAsync(payment);
            return Ok(processedPayment);
        }
        catch (Exception ex)
        {
            return StatusCode(500,
                new ErrorResponse("An internal server error occurred while processing the payment.",
                ex.Message));
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelAccommodationBooking.Dtos.Error;
using TravelAccommodationBooking.Services.Interfaces;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Dtos.Payment;
using AutoMapper;

namespace TravelAccommodationBooking.API.Controllers;

[Route("payments")]
[ApiController]
[Authorize]
public class PaymentController : ControllerBase
{
    private readonly IPaymentService _paymentService;
    private readonly IMapper _mapper;

    public PaymentController(IPaymentService paymentService, IMapper mapper)
    {
        _paymentService = paymentService;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> ProcessPayment([FromBody] PaymentDto paymentDto)
    {
        try
        {
            var payment = _mapper.Map<Payment>(paymentDto);
            var processedPayment = await _paymentService.ProcessPaymentAsync(payment);
            var createdPaymentDto = _mapper.Map<PaymentDto>(processedPayment);
            
            return Ok(createdPaymentDto);
        }
        catch (Exception ex)
        {
            return StatusCode(500,
                new ErrorResponse("An internal server error occurred while processing the payment.",
                ex.Message));
        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SendGrid;
using SendGrid.Helpers.Mail;

using TravelAccommodationBooking.Services.Interfaces;

namespace TravelAccommodationBooking.Services
{
    public class EmailService : IEmailService
    {
        private readonly ILogger<EmailService> _logger;
        private readonly SendGridClient _client;
        private readonly EmailAddress _fromEmail;

        public EmailService(IConfiguration configuration, ILogger<EmailService> logger)
        {
            _logger = logger;
            var apiKey = configuration["SendGrid:ApiKey"];
            _client = new SendGridClient(apiKey);
            _fromEmail = new EmailAddress(configuration["SendGrid:FromEmail"], configuration["SendGrid:FromName"]);
        }

        public async Task SendEmailAsync(string to, string subject, string body)
        {
            var toEmail = new EmailAddress(to);
            var msg = MailHelper.CreateSingleEmail(_fromEmail, toEmail, subject, body, body);
            var response = await _client.SendEmailAsync(msg);

            if (!response.IsSuccessStatusCode)
            {
                var errorMessage = await response.Body.ReadAsStringAsync();
                _logger.LogError($"Error sending email: {errorMessage}");
                throw new ApplicationException($"SendGrid error: {errorMessage}");
            }

            _logger.LogInformation("Email sent successfully to {Email}", to);
        }
    }
}

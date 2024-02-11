using GloboTickets.TicketsManagement.Application.Models.Mail;

namespace GloboTickets.TicketsManagement.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmailAsync(Email email);
    }
}

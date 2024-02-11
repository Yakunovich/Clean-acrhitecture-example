namespace GloboTickets.TicketsManagement.Application.Models.Mail
{
    public class EmailSettings
    {
        public string ApiKey { get; set; } = string.Empty;
        public string FromAdress { get; set; } = string.Empty;
        public string FromName { get; set; } = string.Empty;
    }
}

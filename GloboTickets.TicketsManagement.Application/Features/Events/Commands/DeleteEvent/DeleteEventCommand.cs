using MediatR;

namespace GloboTickets.TicketsManagement.Application.Features.Events.Commands.DeleteEvent
{
    public class DeleteEventCommand: IRequest
    {
        public Guid EventId { get; set; }
    }
}

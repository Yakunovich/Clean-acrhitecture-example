using MediatR;

namespace GloboTickets.TicketsManagement.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventsListQuery: IRequest<List<EventListVm>>
    {

    }
}

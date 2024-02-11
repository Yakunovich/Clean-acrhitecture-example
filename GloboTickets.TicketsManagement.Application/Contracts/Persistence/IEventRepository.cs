using GloboTickets.TicketsManagement.Domain.Entities;

namespace GloboTickets.TicketsManagement.Application.Contracts.Persistence
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
        Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);
    }
}

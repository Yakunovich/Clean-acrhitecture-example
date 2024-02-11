using GloboTickets.TicketsManagement.Application.Contracts.Persistence;
using GloboTickets.TicketsManagement.Domain.Entities;

namespace Globotickets.TicketsManagement.Persistanse.Repositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        public EventRepository(GloboTicketsDbContext dbContext) : base(dbContext)
        {
        }

        public Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate)
        {
            var matches = _dbContext.Events.Any(e => e.Name.Equals(name) &&
                e.Date.Equals(eventDate));
            return Task.FromResult(matches);
        }
    }
}

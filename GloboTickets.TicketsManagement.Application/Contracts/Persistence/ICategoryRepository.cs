using GloboTickets.TicketsManagement.Domain.Entities;

namespace GloboTickets.TicketsManagement.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents);
    }
}

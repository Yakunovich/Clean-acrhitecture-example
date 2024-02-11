using GloboTickets.TicketsManagement.Application.Contracts.Persistence;
using GloboTickets.TicketsManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Globotickets.TicketsManagement.Persistanse.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(GloboTicketsDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents)
        {
            var allCategories = await _dbContext.Categories.Include(c => c.Events).ToListAsync();
            if (!includePassedEvents)
            {
                allCategories.ForEach(p => p.Events.ToList().RemoveAll(c => c.Date < DateTime.Today));
            }
            return allCategories;
        }
    }
}

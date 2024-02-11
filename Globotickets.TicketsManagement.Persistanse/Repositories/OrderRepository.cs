using GloboTickets.TicketsManagement.Application.Contracts.Persistence;
using GloboTickets.TicketsManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Globotickets.TicketsManagement.Persistanse.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(GloboTicketsDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Order>> GetPagedOrdersForMonth(DateTime date, int page, int size)
        {
            return await _dbContext.Orders.Where(o => o.OrderPlaced.Month == date.Month
                && o.OrderPlaced.Year == date.Year)
                .Skip((page - 1) * size).Take(size)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<int> GetTotalCountOfOrdersForMonth(DateTime date)
        {
            return await _dbContext.Orders.CountAsync(o => o.OrderPlaced.Month == date.Month
                && o.OrderPlaced.Year == date.Year);
        }
    }
}

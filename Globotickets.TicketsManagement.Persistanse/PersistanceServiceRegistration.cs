using Globotickets.TicketsManagement.Persistanse.Repositories;
using GloboTickets.TicketsManagement.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Globotickets.TicketsManagement.Persistanse
{
    public static class PersistanceServiceRegistration
    {
        public static IServiceCollection AddPersistanceService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GloboTicketsDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString
                    ("GloboticketsTicketsManagementConnectionString")));
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IEventRepository, EventRepository>();

            return services;
        }
    }
}

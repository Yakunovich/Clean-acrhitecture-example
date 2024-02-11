using AutoMapper;
using GloboTickets.TicketsManagement.Application.Features.Categories.Commands.CreateCateogry;
using GloboTickets.TicketsManagement.Application.Features.Categories.Queries.GetCategoriesList;
using GloboTickets.TicketsManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using GloboTickets.TicketsManagement.Application.Features.Events.Commands.CreateEvent;
using GloboTickets.TicketsManagement.Application.Features.Events.Commands.UpdateEvent;
using GloboTickets.TicketsManagement.Application.Features.Events.Queries.GetEventDetail;
using GloboTickets.TicketsManagement.Application.Features.Events.Queries.GetEventsList;
using GloboTickets.TicketsManagement.Application.Features.Orders.GetOrdersForMonth;
using GloboTickets.TicketsManagement.Domain.Entities;

namespace GloboTickets.TicketsManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            //CreateMap<Event, EventExportDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();

            CreateMap<Order, OrdersForMonthDto>();
        }
    }
}

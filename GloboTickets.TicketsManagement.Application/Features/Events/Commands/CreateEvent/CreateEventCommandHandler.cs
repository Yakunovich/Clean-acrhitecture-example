using AutoMapper;
using GloboTickets.TicketsManagement.Application.Contracts.Infrastructure;
using GloboTickets.TicketsManagement.Application.Contracts.Persistence;
using GloboTickets.TicketsManagement.Application.Models.Mail;
using GloboTickets.TicketsManagement.Domain.Entities;
using MediatR;

namespace GloboTickets.TicketsManagement.Application.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, Guid>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;


        public CreateEventCommandHandler(IMapper mapper, IEventRepository eventRepository, IEmailService emailService)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
            _emailService = emailService;
        }

        public async Task<Guid> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateEventCommandValidator(_eventRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new Exceptions.ValidationException(validationResult);

            var @event = _mapper.Map<Event>(request);

            @event = await _eventRepository.AddAsync(@event);

            var email = new Email() { To = "xxx@gmail.com", Body = $"A new event was created: {request}", Subject = "A new event was created" };

            try
            {
                await _emailService.SendEmailAsync(email);
            }
            catch (Exception ex)
            {
                //logging
            }

            return @event.EventId;
        }
    }
}
using GloboTickets.TicketsManagement.Application.Responses;

namespace GloboTickets.TicketsManagement.Application.Features.Categories.Commands.CreateCateogry
{
    public class CreateCategoryCommandResponse: BaseResponse
    {
        public CreateCategoryCommandResponse(): base()
        {

        }

        public CreateCategoryDto Category { get; set; } = default!;
    }
}
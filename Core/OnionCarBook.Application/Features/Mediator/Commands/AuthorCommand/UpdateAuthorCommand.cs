using MediatR;

namespace OnionCarBook.Application.Features.Mediator.Commands.AuthorCommand;
public class UpdateAuthorCommand : IRequest
{
    public int AuthorId { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
}

using MediatR;

namespace OnionCarBook.Application.Features.Mediator.Commands.AuthorCommand;
public class RemoveAuthorCommand : IRequest
{
    public int Id { get; set; }
    public RemoveAuthorCommand(int id)
    {
        Id = id;
    }
}

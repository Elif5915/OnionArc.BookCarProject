using MediatR;

namespace OnionCarBook.Application.Features.Mediator.Commands.BlogCommand;
public class RemoveBlogCommand: IRequest
{
    public int Id { get; set; }

    public RemoveBlogCommand(int id)
    {
        Id = id;
    }
}

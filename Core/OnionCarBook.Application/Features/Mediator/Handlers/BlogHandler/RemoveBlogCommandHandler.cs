using MediatR;
using OnionCarBook.Application.Features.Mediator.Commands.BlogCommand;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.BlogHandler;
public class RemoveBlogCommandHandler : IRequestHandler<RemoveBlogCommand>
{
    private readonly IRepository<Blog> _repository;

    public RemoveBlogCommandHandler(IRepository<Blog> repository)
    {
        _repository = repository;
    }
    public async Task Handle(RemoveBlogCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
    }
}

using MediatR;
using OnionCarBook.Application.Features.Mediator.Commands.FeatureCommand;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.AuthorHandler;
public class RemoveAuthorCommandHandler : IRequestHandler<RemoveFeatureCommand>
{
    private readonly IRepository<Author> _repository;

    public RemoveAuthorCommandHandler(IRepository<Author> repository)
    {
        _repository = repository;
    }
    public async Task Handle(RemoveFeatureCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
    }
}

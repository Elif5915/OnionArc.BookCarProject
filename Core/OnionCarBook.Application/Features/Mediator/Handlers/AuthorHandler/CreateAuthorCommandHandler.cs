using MediatR;
using OnionCarBook.Application.Features.Mediator.Commands.AuthorCommand;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.AuthorHandler;
public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand>
{
    private readonly IRepository<Author> _repository;

    public CreateAuthorCommandHandler(IRepository<Author> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new Author
        {
            Name = request.Name,
            ImageUrl = request.ImageUrl,
            Description = request.Description

        });
    }
}

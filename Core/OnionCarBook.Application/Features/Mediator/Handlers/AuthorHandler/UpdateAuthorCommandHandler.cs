using MediatR;
using OnionCarBook.Application.Features.Mediator.Commands.AuthorCommand;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.AuthorHandler;
public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand>
{
    private readonly IRepository<Author> _repository;
    public UpdateAuthorCommandHandler(IRepository<Author> repository)
    {
        _repository = repository;
    }
    public async Task Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
    {
      var values = await _repository.GetByIdAsync(request.AuthorId);
        values.Name = request.Name;
        values.ImageUrl = request.ImageUrl;
        values.Description = request.Description;
        await _repository.UpdateAsync(values);
    }
}

using MediatR;
using OnionCarBook.Application.Features.Mediator.Commands.BlogCommand;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.BlogHandler;
public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
{
    private readonly IRepository<Blog> _repository;

    public UpdateBlogCommandHandler(IRepository<Blog> repository)
    {
        _repository = repository;
    }
    public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.BlogId);
        values.Title = request.Title;
        values.CreatedDate = request.CreatedDate;
        values.AuthorId = request.AuthorId;
        values.CategoryId = request.CategoryId;
        values.CoverImageUrl = request.CoverImageUrl;
        await _repository.UpdateAsync(values);
    }
}

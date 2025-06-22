using MediatR;
using OnionCarBook.Application.Features.Mediator.Commands.BlogCommand;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.BlogHandler;
public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand>
{
    private readonly IRepository<Blog> _repository;

    public CreateBlogCommandHandler(IRepository<Blog> repository)
    {
        _repository = repository;
    }
    public async Task Handle(CreateBlogCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new Blog
        {
            Title = request.Title,
            AuthorId = request.AuthorId,
            CoverImageUrl = request.CoverImageUrl,
            CreatedDate = request.CreatedDate,
            CategoryId = request.CategoryId
        });
    }
}

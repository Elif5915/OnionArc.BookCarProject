using MediatR;
using OnionCarBook.Application.Features.Mediator.Queries.BlogQueries;
using OnionCarBook.Application.Features.Mediator.Results.BlogResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.BlogHandler;
public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
{
    private readonly IRepository<Blog> _repository;

    public GetBlogByIdQueryHandler(IRepository<Blog> repository)
    {
        _repository = repository;
    }
    public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.Id);
        return new GetBlogByIdQueryResult
        {
            BlogId = values.BlogId,
            Title = values.Title,
            AuthorId = values.AuthorId,
            CoverImageUrl = values.CoverImageUrl,
            CreatedDate = values.CreatedDate,
            CategoryId = values.CategoryId

        };
    }
}


using MediatR;
using OnionCarBook.Application.Features.Mediator.Queries.BlogQueries;
using OnionCarBook.Application.Features.Mediator.Results.BlogResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.BlogHandler;
public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<GetBlogQueryResult>>
{
    private readonly IRepository<Blog> _repository;

    public GetBlogQueryHandler(IRepository<Blog> repository)
    {
        _repository = repository;
    }
    public async Task<List<GetBlogQueryResult>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetBlogQueryResult
        {
            BlogId = x.BlogId,
            AuthorId = x.AuthorId,
            Title = x.Title,
            CategoryId = x.CategoryId,
            CoverImageUrl = x.CoverImageUrl,
            CreatedDate = x.CreatedDate

        }).ToList();
    }
}

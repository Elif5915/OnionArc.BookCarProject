using MediatR;
using OnionCarBook.Application.Features.Mediator.Queries.BlogQueries;
using OnionCarBook.Application.Features.Mediator.Results.BlogResult;
using OnionCarBook.Application.Interfaces.BlogInterfaces;

namespace OnionCarBook.Application.Features.Mediator.Handlers.BlogHandler;
public class GetLast3BlogsWithAuthorsQueryHandler : IRequestHandler<GetLast3BlogsWithAuthorsQuery, List<GetLast3BlogsWithAuthorsQueryResult>>
{
    private readonly IBlogRepository _blogRepository;

    public GetLast3BlogsWithAuthorsQueryHandler(IBlogRepository blogRepository)
    {
        _blogRepository = blogRepository;
    }

    public async Task<List<GetLast3BlogsWithAuthorsQueryResult>> Handle(GetLast3BlogsWithAuthorsQuery request, CancellationToken cancellationToken)
    {
        var values = _blogRepository.GetLast3BlogsWithAuthors();
        return values.Select(x => new GetLast3BlogsWithAuthorsQueryResult
        {
            BlogId = x.BlogId,
            Title = x.Title,
            AuthorId = x.AuthorId,
            CategoryId = x.CategoryId,
            CreatedDate = x.CreatedDate,
            CoverImageUrl = x.CoverImageUrl,
            AuthorName = x.Author.Name

        }).ToList();
    }
}


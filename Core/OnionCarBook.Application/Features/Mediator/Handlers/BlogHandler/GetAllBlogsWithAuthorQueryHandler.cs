using MediatR;
using OnionCarBook.Application.Features.Mediator.Queries.BlogQueries;
using OnionCarBook.Application.Features.Mediator.Results.BlogResult;
using OnionCarBook.Application.Interfaces.BlogInterfaces;

namespace OnionCarBook.Application.Features.Mediator.Handlers.BlogHandler;
public class GetAllBlogsWithAuthorQueryHandler : IRequestHandler<GetAllBlogsWithAuthorQuery, List<GetAllBlogsWithAuthorQueryResult>>
{
    private readonly IBlogRepository _blogRepository;

    public GetAllBlogsWithAuthorQueryHandler(IBlogRepository blogRepository)
    {
        _blogRepository = blogRepository;
    }
    public async Task<List<GetAllBlogsWithAuthorQueryResult>> Handle(GetAllBlogsWithAuthorQuery request, CancellationToken cancellationToken)
    {
        var values = _blogRepository.GetAllBlogsWithAuthors();
        return values.Select(x => new GetAllBlogsWithAuthorQueryResult
        {
            BlogId = x.BlogId,
            Title = x.Title,
            AuthorId = x.AuthorId,
           // AuthorName = x.Author.Name.ToString(),
            CategoryId = x.CategoryId,
            //CategoryName = x.Category.Name.ToString(),
            CreatedDate = x.CreatedDate,
            CoverImageUrl = x.CoverImageUrl,
            Description = x.Description

        }).ToList();
    }
}

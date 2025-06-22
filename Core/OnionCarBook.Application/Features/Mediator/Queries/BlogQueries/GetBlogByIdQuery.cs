using MediatR;
using OnionCarBook.Application.Features.Mediator.Results.BlogResult;

namespace OnionCarBook.Application.Features.Mediator.Queries.BlogQueries;
public class GetBlogByIdQuery: IRequest<GetBlogByIdQueryResult>
{
    public int Id { get; set; }
    public GetBlogByIdQuery(int id)
    {
        Id = id;
    }
}

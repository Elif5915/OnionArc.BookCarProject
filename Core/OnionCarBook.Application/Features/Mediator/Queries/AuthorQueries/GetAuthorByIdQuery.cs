using MediatR;
using OnionCarBook.Application.Features.Mediator.Results.AuthorResult;

namespace OnionCarBook.Application.Features.Mediator.Queries.AuthorQueries;
public class GetAuthorByIdQuery : IRequest<GetAuthorByIdQueryResult>
{
    public int Id { get; set; }

    public GetAuthorByIdQuery(int id)
    {
        Id = id;
    }
}

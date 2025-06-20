using MediatR;
using OnionCarBook.Application.Features.Mediator.Results.AuthorResult;

namespace OnionCarBook.Application.Features.Mediator.Queries.AuthorQueries;
public class GetAuthorQuery : IRequest<List<GetAuthorQueryResult>>
{
}

using MediatR;
using OnionCarBook.Application.Features.Mediator.Queries.AuthorQueries;
using OnionCarBook.Application.Features.Mediator.Results.AuthorResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.AuthorHandler;
public class GetAuthorQueryHandler : IRequestHandler<GetAuthorQuery, List<GetAuthorQueryResult>>
{
    private readonly IRepository<Author> _repository;

    public GetAuthorQueryHandler(IRepository<Author> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetAuthorQueryResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetAuthorQueryResult
        {
            AuthorId = x.AuthorId,
            Name = x.Name,
            ImageUrl = x.ImageUrl,
            Description = x.ImageUrl

        }).ToList();
    }
}

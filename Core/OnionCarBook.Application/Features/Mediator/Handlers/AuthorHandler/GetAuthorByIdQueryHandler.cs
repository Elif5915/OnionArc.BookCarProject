using MediatR;
using OnionCarBook.Application.Features.Mediator.Queries.AuthorQueries;
using OnionCarBook.Application.Features.Mediator.Results.AuthorResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.AuthorHandler;
public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdQueryResult>
{
    private readonly IRepository<Author> _repository;

    public GetAuthorByIdQueryHandler(IRepository<Author> repository)
    {
        _repository = repository;
    }
    public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.Id);
        return new GetAuthorByIdQueryResult
        {
            Name = values.Name,
            ImageUrl = values.ImageUrl,
            Description = values.Description
        };
    }
}

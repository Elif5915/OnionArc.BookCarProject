using MediatR;
using OnionCarBook.Application.Features.Mediator.Queries.ServiceQueries;
using OnionCarBook.Application.Features.Mediator.Results.LocationResult;
using OnionCarBook.Application.Features.Mediator.Results.ServiceResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.ServiceHandler;
public class GetServiceQueryHandler : IRequestHandler<GetServiceQuery, List<GetServiceQueryResult>>
{
    private readonly IRepository<Service> _repository;

    public GetServiceQueryHandler(IRepository<Service> repository)
    {
        _repository = repository;
    }
    public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetServiceQueryResult
        {
            ServiceId = x.ServiceId,
            Title = x.Title,
            Description = x.Description,
            IconUrl = x.IconUrl
        }).ToList();
    }
}

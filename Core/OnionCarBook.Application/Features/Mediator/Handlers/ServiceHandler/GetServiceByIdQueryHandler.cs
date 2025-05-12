using MediatR;
using OnionCarBook.Application.Features.Mediator.Queries.LocationQueries;
using OnionCarBook.Application.Features.Mediator.Queries.ServiceQueries;
using OnionCarBook.Application.Features.Mediator.Results.LocationResult;
using OnionCarBook.Application.Features.Mediator.Results.ServiceResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.Mediator.Handlers.ServiceHandler;
public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
{
    private readonly IRepository<Service> _repository;

    public GetServiceByIdQueryHandler(IRepository<Service> repository)
    {
        _repository = repository;
    }
    public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.Id);
        return new GetServiceByIdQueryResult
        {
            ServiceId = values.ServiceId,
            Title = values.Title,
            Description = values.Description,
            IconUrl = values.IconUrl
        };
    }
}

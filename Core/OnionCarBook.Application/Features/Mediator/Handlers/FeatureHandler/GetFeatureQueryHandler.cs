using MediatR;
using OnionCarBook.Application.Features.Mediator.Queries.FeatureQueries;
using OnionCarBook.Application.Features.Mediator.Results.FeatureResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.FeatureHandler;
public class GetFeatureQueryHandler : IRequestHandler<GetFeatureQuery, List<GetFeatureQueryResult>>
{
    private readonly IRepository<Feature> _repository;

    public GetFeatureQueryHandler(IRepository<Feature> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetFeatureQueryResult>> Handle(GetFeatureQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetFeatureQueryResult { 
            FeatureId = x.FeatureId,
            Name = x.Name
        }).ToList();
    }
}

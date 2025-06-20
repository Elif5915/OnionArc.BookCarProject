using MediatR;
using OnionCarBook.Application.Features.Mediator.Results.FeatureResult;

namespace OnionCarBook.Application.Features.Mediator.Queries.FeatureQueries;
public class GetFeatureQuery :IRequest<List<GetFeatureQueryResult>>
{
}

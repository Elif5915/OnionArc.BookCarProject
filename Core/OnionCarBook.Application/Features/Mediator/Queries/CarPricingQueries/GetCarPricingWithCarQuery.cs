using MediatR;
using OnionCarBook.Application.Features.Mediator.Results.CarPricingResult;

namespace OnionCarBook.Application.Features.Mediator.Queries.CarPricingQueries;
public class GetCarPricingWithCarQuery : IRequest<List<GetCarPricingWithCarQueryResult>>
{
}

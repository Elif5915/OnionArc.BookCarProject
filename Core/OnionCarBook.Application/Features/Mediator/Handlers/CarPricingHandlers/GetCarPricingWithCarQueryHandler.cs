using MediatR;
using OnionCarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using OnionCarBook.Application.Features.Mediator.Results.CarPricingResult;
using OnionCarBook.Application.Interfaces.CarPricingInterfaces;

namespace OnionCarBook.Application.Features.Mediator.Handlers.CarPricingHandlers;
public class GetCarPricingWithCarQueryHandler : IRequestHandler<GetCarPricingWithCarQuery, List<GetCarPricingWithCarQueryResult>>
{
    private readonly ICarPricingRepository _carPricingRepository;

    public GetCarPricingWithCarQueryHandler(ICarPricingRepository carPricingRepository)
    {
        _carPricingRepository = carPricingRepository;
    }

    public async Task<List<GetCarPricingWithCarQueryResult>> Handle(GetCarPricingWithCarQuery request, CancellationToken cancellationToken)
    {
        var values = _carPricingRepository.GetCarPricingWithCars();
        return values.Select(x => new GetCarPricingWithCarQueryResult
        {
          Amount = x.Amout,
          Brand = x.Car.Brand.Name,
          CarPricingId = x.CarPricingId,
          Model = x.Car.Model,
          CoverImageUrl = x.Car.CoverImageuRL

        }).ToList();
    }
}

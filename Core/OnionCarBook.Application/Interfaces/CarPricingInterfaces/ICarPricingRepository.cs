using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Interfaces.CarPricingInterfaces;
public interface ICarPricingRepository
{
    List<CarPricing> GetCarPricingWithCars();
}

using Microsoft.EntityFrameworkCore;
using OnionCarBook.Application.Interfaces.CarPricingInterfaces;
using OnionCarBook.Domain.Entities;
using OnionCarBook.Persistence.Context;

namespace OnionCarBook.Persistence.Repositories.CarPricingRepositories;
public class CarPricingRepository : ICarPricingRepository
{
    private readonly CarBookContext _context;

    public CarPricingRepository(CarBookContext context)
    {
        _context = context;
    }
    public List<CarPricing> GetCarPricingWithCars()
    {
        var values = _context.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand).Include(x => x.Pricing).ToList();
        return values;
    }
}

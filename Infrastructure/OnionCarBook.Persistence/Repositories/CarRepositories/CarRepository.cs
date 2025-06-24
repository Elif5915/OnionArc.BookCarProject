using Microsoft.EntityFrameworkCore;
using OnionCarBook.Application.Interfaces.CarInterfaces;
using OnionCarBook.Domain.Entities;
using OnionCarBook.Persistence.Context;

namespace OnionCarBook.Persistence.Repositories.CarRepositories;
public class CarRepository : ICarRepository
{
    private readonly CarBookContext _context;

    public CarRepository(CarBookContext context)
    {
        _context = context;
    }

    public List<Car> GetCarsListWithBrands()
    {
        var values = _context.Cars.Include(x => x.Brand).ToList();
        return values;
    }
    public List<Car> GetLastFiveCarsWithBrands()
    {
        var cars = _context.Cars.Include(x => x.Brand).OrderByDescending(x => x.CarId).Take(5).ToList();
        return cars;
    }
}

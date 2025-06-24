using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Interfaces.CarInterfaces;
public interface ICarRepository
{
    List<Car> GetCarsListWithBrands();
    List<Car> GetLastFiveCarsWithBrands();
}

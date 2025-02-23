using OnionCarBook.Application.Features.CQRS.Results.CarResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Application.Interfaces.CarInterfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.CQRS.Handlers.CarHandlers;
public class GetCarWithBrandQueryHandler
{
    //private readonly IRepository<Car> _repository;
    //public GetCarWithBrandQueryHandler(IRepository<Car> repository)
    //{
    //    _repository = repository;
    //}

    private readonly ICarRepository _carRepository;

    public GetCarWithBrandQueryHandler(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }

    public List<GetCarWithBrandQueryResult> Handle()
    {
        var value = _carRepository.GetCarsListWithBrands();
        return value.Select(x => new GetCarWithBrandQueryResult
        {
            BrandId = x.BrandId,
            BigImageUrl = x.BigImageUrl,
            CarId = x.CarId,
            CoverImageuRL = x.CoverImageuRL,
            Fuel = x.Fuel,
            Km = x.Km,
            Luggage = x.Luggage,
            Model = x.Model,
            Seat = x.Seat,
            Transmission = x.Transmission,
            BrandName = x.Brand.Name

        }).ToList();

    }
}

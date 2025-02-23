using OnionCarBook.Application.Features.CQRS.Results.CarResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.CQRS.Handlers.CarHandlers;
public class GetCarQueryHandler
{
    private readonly IRepository<Car> _repository;

    public GetCarQueryHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetCarQueryResult>> Handle()
    {
        var value = await _repository.GetAllAsync();
        return value.Select(x => new GetCarQueryResult
        {
            BrandId = x.BrandId,
            BigImageUrl = x.BigImageUrl,
            CarId = x.CarId,
            CoverImageuRL = x.CoverImageuRL,
            Fuel = x.Fuel,
            Km = x.Km,
            Luggage = x.Luggage,
            Model =x.Model,
            Seat =x.Seat,
            Transmission = x.Transmission


        }).ToList();

    }
}

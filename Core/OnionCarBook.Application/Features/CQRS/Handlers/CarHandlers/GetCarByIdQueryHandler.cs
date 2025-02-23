using OnionCarBook.Application.Features.CQRS.Queries.BrandQueries;
using OnionCarBook.Application.Features.CQRS.Queries.CarQueries;
using OnionCarBook.Application.Features.CQRS.Results.CarResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.CQRS.Handlers.CarHandlers;
public class GetCarByIdQueryHandler
{
    private readonly IRepository<Car> _repository;

    public GetCarByIdQueryHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }
    public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
    {
        var values = await _repository.GetByIdAsync(query.Id);
        return new GetCarByIdQueryResult
        {
         BrandId = values.BrandId,
         BigImageUrl = values.BigImageUrl,
         CoverImageuRL = values.CoverImageuRL,
         Fuel = values.Fuel,
         CarId = values.CarId,
         Transmission = values.Transmission,
         Seat = values.Seat,
         Model = values.Model,
         Km = values.Km,
         Luggage = values.Luggage

        };
    }
}

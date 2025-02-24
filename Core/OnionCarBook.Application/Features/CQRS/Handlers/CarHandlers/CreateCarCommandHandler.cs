﻿using OnionCarBook.Application.Features.CQRS.Commands.BrandCommands;
using OnionCarBook.Application.Features.CQRS.Commands.CarCommands;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.CQRS.Handlers.CarHandlers;
public class CreateCarCommandHandler
{
    private readonly IRepository<Car> _repository;

    public CreateCarCommandHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateCarCommand command)
    {
        await _repository.CreateAsync(new Car
        {
           BigImageUrl = command.BigImageUrl,
           Luggage = command.Luggage,
           Km = command.Km,
           Seat = command.Seat,
           Model = command.Model,
           Transmission = command.Transmission,
           CoverImageuRL = command.CoverImageuRL,
           BrandId = command.BrandId,
           Fuel= command.Fuel

        });
    }
}

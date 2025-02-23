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
public class UpdateCarCommandHandler
{
    private readonly IRepository<Car> _repository;

    public UpdateCarCommandHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }
    public async Task Handle(UpdateCarCommand command)
    {
        var values = await _repository.GetByIdAsync(command.CarId);
        values.Fuel = command.Fuel;
        values.Transmission = command.Transmission;
        values.BigImageUrl = command.BigImageUrl;
        values.BrandId = command.BrandId;
        values.CoverImageuRL = command.CoverImageuRL;
        values.Km = command.Km;
        values.Luggage = command.Luggage;
        values.Model = command.Model;
        values.Seat = command.Seat;

        await _repository.UpdateAsync(values);
    }
}

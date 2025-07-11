﻿using Microsoft.AspNetCore.Mvc;
using OnionCarBook.Application.Features.CQRS.Commands.CarCommands;
using OnionCarBook.Application.Features.CQRS.Handlers.CarHandlers;
using OnionCarBook.Application.Features.CQRS.Queries.CarQueries;

namespace OnionCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CarController : ControllerBase
{
    private readonly CreateCarCommandHandler _createCarCommandHandler;
    private readonly GetCarByIdQueryHandler _getCarByIdQueryHandler;
    private readonly GetCarQueryHandler _getCarQueryHandler;
    private readonly RemoveCarCommandHandler _removeCarCommandHandler;
    private readonly UpdateCarCommandHandler _updateCarCommandHandler;
    private readonly GetCarWithBrandQueryHandler _getCarWithBrandQueryHandler;
    private readonly GetLast5CarsWithBrandQueryHandler _getLast5CarsWithBrandQueryHandler;

    public CarController(CreateCarCommandHandler createCarCommandHandler, GetCarByIdQueryHandler getCarByIdQueryHandler, GetCarQueryHandler getCarQueryHandler, RemoveCarCommandHandler removeCarCommandHandler, UpdateCarCommandHandler updateCarCommandHandler, GetCarWithBrandQueryHandler getCarWithBrandQueryHandler, GetLast5CarsWithBrandQueryHandler getLast5CarsWithBrandQueryHandler)
    {
        _createCarCommandHandler = createCarCommandHandler;
        _getCarByIdQueryHandler = getCarByIdQueryHandler;
        _getCarQueryHandler = getCarQueryHandler;
        _removeCarCommandHandler = removeCarCommandHandler;
        _updateCarCommandHandler = updateCarCommandHandler;
        _getCarWithBrandQueryHandler = getCarWithBrandQueryHandler;
        _getLast5CarsWithBrandQueryHandler = getLast5CarsWithBrandQueryHandler;
 
    }

    [HttpGet]
    public async Task<IActionResult> CarList()
    {
        var values = await _getCarQueryHandler.Handle();
        return Ok(values);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetCar(int id)
    {
        var value = await _getCarByIdQueryHandler.Handle(new GetCarByIdQuery(id));
        return Ok(value);
    }
    [HttpPost]
    public async Task<IActionResult> CreateCar(CreateCarCommand command)
    {
        await _createCarCommandHandler.Handle(command);
        return Ok("Araba Bilgisi Eklendi");
    }
    [HttpDelete]
    public async Task<IActionResult> RemoveCar(int id)
    {
        await _removeCarCommandHandler.Handle(new RemoveCarCommand(id));
        return Ok("Silme İşlemi Başarıyla Tamamlandı");
    }
    [HttpPut]
    public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
    {
        await _updateCarCommandHandler.Handle(command);
        return Ok("Araba Güncellendi");
    }

    [HttpGet("GetCarWithBrand")]
    public IActionResult GetCarWithBrand()
    {
        var values = _getCarWithBrandQueryHandler.Handle();
        return Ok(values);
    }
    [HttpGet("GetLast5CarsWithBrandQueryHandler")]
    public IActionResult GetLastFiveCarsWithBrand()
    {
        var cars = _getLast5CarsWithBrandQueryHandler.Handle();
        return Ok(cars);
    }
}

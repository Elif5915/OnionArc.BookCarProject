﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionCarBook.Application.Features.CQRS.Commands.BrandCommands;
using OnionCarBook.Application.Features.CQRS.Handlers.BrandHandlers;
using OnionCarBook.Application.Features.CQRS.Queries.BrandQueries;

namespace OnionCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BrandsController : ControllerBase
{
    private readonly CreateBrandCommandHandler _createBrandCommandHandler;
    private readonly GetBrandByIdQueryHandler _getBrandByIdQueryHandler;
    private readonly GetBrandQueryHandler _getBrandQueryHandler;
    private readonly RemoveBrandCommandHandler _removeBrandCommandHandler;
    private readonly UpdateBrandCommandHandler _updateBrandCommandHandler;

    public BrandsController(CreateBrandCommandHandler createBrandCommandHandler, GetBrandByIdQueryHandler getBrandByIdQueryHandler, GetBrandQueryHandler getBrandQueryHandler, RemoveBrandCommandHandler removeBrandCommandHandler, UpdateBrandCommandHandler updateBrandCommandHandler)
    {
        _createBrandCommandHandler = createBrandCommandHandler;
        _getBrandByIdQueryHandler = getBrandByIdQueryHandler;
        _getBrandQueryHandler = getBrandQueryHandler;
        _removeBrandCommandHandler = removeBrandCommandHandler;
        _updateBrandCommandHandler = updateBrandCommandHandler;
    }

    [HttpGet]
    public async Task<IActionResult> BrandList()
    {
        var values = await _getBrandQueryHandler.Handle();
        return Ok(values);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetBrand(int id)
    {
        var value = await _getBrandByIdQueryHandler.Handle(new GetBrandByIdQuery(id));
        return Ok(value);
    }
    [HttpPost]
    public async Task<IActionResult> CreateBrand(CreateBrandCommand command)
    {
        await _createBrandCommandHandler.Handle(command);
        return Ok("Marka Bilgisi Eklendi");
    }
    [HttpDelete]
    public async Task<IActionResult> RemoveBrand(int id)
    {
        await _removeBrandCommandHandler.Handle(new RemoveBrandCommand(id));
        return Ok("Silme İşlemi Başarıyla Tamamlandı");
    }
    [HttpPut]
    public async Task<IActionResult> UpdateBrand(UpdateBrandCommand command)
    {
        await _updateBrandCommandHandler.Handle(command);
        return Ok("Marka Güncellendi");
    }

}

﻿using Microsoft.AspNetCore.Mvc;
using OnionCarBook.Application.Features.CQRS.Commands.AboutCommands;
using OnionCarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using OnionCarBook.Application.Features.CQRS.Queries.AboutQueries;

namespace OnionCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AboutsController : ControllerBase
{
    private readonly CreateAboutCommandHandler _createAboutCommandHandler;
    private readonly GetAboutByIdQueryHandler _getAboutByIdQueryHandler;
    private readonly GetAboutQueryHandler _getAboutQueryHandler;
    private readonly RemoveAboutCommandHandler _removeAboutCommandHandler;
    private readonly UpdateAboutCommandHandler _updateAboutCommandHandler;

    public AboutsController(CreateAboutCommandHandler createAboutCommandHandler, GetAboutByIdQueryHandler getAboutByIdQueryHandler, GetAboutQueryHandler getAboutQueryHandler, RemoveAboutCommandHandler removeAboutCommandHandler, UpdateAboutCommandHandler updateAboutCommandHandler)
    {
        _createAboutCommandHandler = createAboutCommandHandler;
        _getAboutByIdQueryHandler = getAboutByIdQueryHandler;
        _getAboutQueryHandler = getAboutQueryHandler;
        _removeAboutCommandHandler = removeAboutCommandHandler;
        _updateAboutCommandHandler = updateAboutCommandHandler;
    }

    [HttpGet]
    public async Task<IActionResult> AboutList()
    {
        var values = await _getAboutQueryHandler.Handle();
        return Ok(values);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAbout(int id)
    {
        var value = await _getAboutByIdQueryHandler.Handle(new GetAboutByIdQuery(id));
        return Ok(value);
    }
    [HttpPost]
    public async Task<IActionResult> CreateAbout(CreateAboutCommand command)
    {
        await _createAboutCommandHandler.Handle(command);
        return Ok("Hakkımda Bilgisi Eklendi");
    }
    [HttpDelete]
    public async Task<IActionResult> RemoveAbout(int id)
    {
        await _removeAboutCommandHandler.Handle(new RemoveAboutCommand(id));
        return Ok("Silme İşlemi Başarıyla Tamamlandı");
    }
    [HttpPut]
    public async Task<IActionResult> UpdateAbout(UpdateAboutCommand command)
    {
        await _updateAboutCommandHandler.Handle(command);
        return Ok("Güncellendi");
    }

}

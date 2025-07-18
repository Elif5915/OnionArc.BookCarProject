﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionCarBook.Application.Features.Mediator.Commands.AuthorCommand;
using OnionCarBook.Application.Features.Mediator.Queries.AuthorQueries;

namespace OnionCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuthorController : ControllerBase
{
    private readonly IMediator _mediator;

    public AuthorController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> AuthorList()
    {
        var values = await _mediator.Send(new GetAuthorQuery());
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAuthor(int id)
    {
        var value = await _mediator.Send(new GetAuthorByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAuthor(CreateAuthorCommand command)
    {
        await _mediator.Send(command);
        return Ok("Yazar başarıyla eklendi.");
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveAuthor(int id)
    {
        await _mediator.Send(new RemoveAuthorCommand(id));
        return Ok("Yazar başarıyla silindi.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAuthor(UpdateAuthorCommand command)
    {
        await _mediator.Send(command);
        return Ok("Yazar başarıyla güncellendi.");
    }
}

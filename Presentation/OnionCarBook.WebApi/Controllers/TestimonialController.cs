﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionCarBook.Application.Features.Mediator.Commands.TestimonialCommand;
using OnionCarBook.Application.Features.Mediator.Queries.TestimonialQueries;

namespace OnionCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TestimonialController : ControllerBase
{
    private readonly IMediator _mediator;
    public TestimonialController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> TestimonialList()
    {
        var values = await _mediator.Send(new GetTestimonialQuery());
        return Ok(values);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdTestimonial(int id)
    {
        var value = await _mediator.Send(new GetTestimonialByIdQuery(id));
        return Ok(value);
    }
    [HttpPost]
    public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommand command)
    {
        await _mediator.Send(command);
        return Ok("Referans başarıyla eklendi.");
    }
    [HttpDelete]
    public async Task<IActionResult> RemoveTestimonial(int id)
    {
        await _mediator.Send(new RemoveTestimonialCommand(id));
        return Ok("Referans başarıyla silindi.");
    }
    [HttpPut]
    public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialCommand command)
    {
        await _mediator.Send(command);
        return Ok("Referans güncellendi");
    }
}

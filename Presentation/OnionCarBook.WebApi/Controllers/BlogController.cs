﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionCarBook.Application.Features.Mediator.Commands.BlogCommand;
using OnionCarBook.Application.Features.Mediator.Queries.BlogQueries;

namespace OnionCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BlogController : ControllerBase
{
    private readonly IMediator _mediator;

    public BlogController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> BlogList()
    {
        var values = await _mediator.Send(new GetBlogQuery());
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetBlog(int id)
    {
        var value = await _mediator.Send(new GetBlogByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
    {
        await _mediator.Send(command);
        return Ok("Blog başarıyla eklendi.");
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveBlog(int id)
    {
        await _mediator.Send(new RemoveBlogCommand(id));
        return Ok("Blog başarıyla silindi.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
    {
        await _mediator.Send(command);
        return Ok("Blog başarıyla güncellendi.");
    }

    [HttpGet("GetLast3BlogsWithAuthorsList")]
    public async Task<IActionResult> GetLast3BlogsWithAuthorsList()
    {
        var values = await _mediator.Send(new GetLast3BlogsWithAuthorsQuery());
        return Ok(values);
    }

    [HttpGet("GetAllBlogsWithAuthorsList")]
    public async Task<IActionResult> GetAllBlogsWithAuthorsList()
    {
        var values = await _mediator.Send(new GetAllBlogsWithAuthorQuery());
        return Ok(values);
    }
}

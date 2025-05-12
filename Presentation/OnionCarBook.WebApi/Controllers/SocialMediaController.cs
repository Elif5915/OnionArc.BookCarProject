using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionCarBook.Application.Features.Mediator.Commands.SocialMediaCommand;
using OnionCarBook.Application.Features.Mediator.Queries.SocialMediaQueries;

namespace OnionCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SocialMediaController : ControllerBase
{
    private readonly IMediator _mediator;
    public SocialMediaController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult>SocialMediaList()
    {
        var values = await _mediator.Send(new GetSocialMediaQuery());
        return Ok(values);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdSocialMedia(int id)
    {
        var value = await _mediator.Send(new GetSocialMediaByIdQuery(id));
        return Ok(value);
    }
    [HttpPost]
    public async Task<IActionResult> CreateSocialMedia(CreateSocialMediaCommand command)
    {
        await _mediator.Send(command);
        return Ok("Sosyal medya başarıyla eklendi.");
    }
    [HttpDelete]
    public async Task<IActionResult> RemoveSocialMedia(int id)
    {
        await _mediator.Send(new RemoveSocialMediaCommand(id));
        return Ok("Sosyal medya  başarıyla silindi.");
    }
    [HttpPut]
    public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaCommand command)
    {
        await _mediator.Send(command);
        return Ok("Sosyal medya  güncellendi");
    }
}

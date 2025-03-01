using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionCarBook.Application.Features.Mediator.Queries.FeatureQueries;

namespace OnionCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class FeaturesController : ControllerBase
{
    private readonly IMediator _mediator;

    public FeaturesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> FeatureList()
    {
        var values = await _mediator.Send(new GetFeatureQuery());
        return Ok(values);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdFeature(int id)
    {
       var value = await _mediator.Send(new GetFeatureByIdQuery(id));
        return Ok(value);
    }
}

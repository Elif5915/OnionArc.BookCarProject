using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionCarBook.Application.Features.Mediator.Commands.PricingCommand;
using OnionCarBook.Application.Features.Mediator.Queries.PricingQueries;

namespace OnionCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PricingController : ControllerBase
{
    private readonly IMediator _mediator;
    public PricingController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> PricingList()
    {
        var values = await _mediator.Send(new GetPricingQuery());
        return Ok(values);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdPricing(int id)
    {
        var value = await _mediator.Send(new GetPricingByIdQuery(id));
        return Ok(value);
    }
    [HttpPost]
    public async Task<IActionResult> CreatePricing(CreatePricingCommand command)
    {
        await _mediator.Send(command);
        return Ok("Fiyatlandırma başarıyla eklendi.");
    }
    [HttpDelete]
    public async Task<IActionResult> RemovePricing(int id)
    {
        await _mediator.Send(new RemovePricingCommand(id));
        return Ok("Fiyatlandırma başarıyla silindi.");
    }
    [HttpPut]
    public async Task<IActionResult> UpdatePricing(UpdatePricingCommand command)
    {
        await _mediator.Send(command);
        return Ok("Fiyatlandırma güncellendi");
    }
}

using MediatR;
using OnionCarBook.Application.Features.Mediator.Commands.PricingCommand;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.PricingHandler;
public class UpdatePricingCommandHandler : IRequestHandler<UpdatePricingCommand>
{
    private readonly IRepository<Pricing> _repository;

    public UpdatePricingCommandHandler(IRepository<Pricing> repository)
    {
        _repository = repository;
    }
    public async Task Handle(UpdatePricingCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.PricingId);
        values.Name = request.Name;
        await _repository.UpdateAsync(values);
    }
}

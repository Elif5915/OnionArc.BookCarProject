using MediatR;
using OnionCarBook.Application.Features.Mediator.Commands.PricingCommand;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.Mediator.Handlers.PricingHandler;
public class RemovePricingCommandHandler : IRequestHandler<RemovePricingCommand>
{
    private readonly IRepository<Pricing> _repository;

    public RemovePricingCommandHandler(IRepository<Pricing> repository)
    {
        this._repository = repository;
    }
    public async Task Handle(RemovePricingCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
    }
}

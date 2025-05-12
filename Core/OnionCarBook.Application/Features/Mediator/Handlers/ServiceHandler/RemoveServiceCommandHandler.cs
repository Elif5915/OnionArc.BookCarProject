using MediatR;
using OnionCarBook.Application.Features.Mediator.Commands.LocationCommand;
using OnionCarBook.Application.Features.Mediator.Commands.ServiceCommand;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.Mediator.Handlers.ServiceHandler;
public class RemoveServiceCommandHandler : IRequestHandler<RemoveServiceCommand>
{
    private readonly IRepository<Service> _repository;

    public RemoveServiceCommandHandler(IRepository<Service> repository)
    {
        this._repository = repository;
    }
    public async Task Handle(RemoveServiceCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
    }
}

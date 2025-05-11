using MediatR;
using OnionCarBook.Application.Features.Mediator.Commands.LocationCommand;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.Mediator.Handlers.LocationHandler;
public class UpdateLocationComandHandler : IRequestHandler<UpdateLocationCommand>
{
    private readonly IRepository<Location> _repository;

    public UpdateLocationComandHandler(IRepository<Location> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.LocationId);
        values.Name = request.Name;
        await _repository.UpdateAsync(values);
    }
}

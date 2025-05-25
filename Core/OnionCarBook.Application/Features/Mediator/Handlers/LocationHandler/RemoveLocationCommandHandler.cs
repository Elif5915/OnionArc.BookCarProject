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
public class RemoveTestimonialCommandHandler : IRequestHandler<RemoveLocationCommand>
{
    private readonly IRepository<Location> _repository;

    public RemoveTestimonialCommandHandler(IRepository<Location> repository)
    {
        this._repository = repository;
    }

    public async Task Handle(RemoveLocationCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
    }
}

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
public class CreateTestimonialCommandHandler : IRequestHandler<CreateLocationCommand>
{
    private readonly IRepository<Location> _repository;

    public CreateTestimonialCommandHandler(IRepository<Location> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateLocationCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new Location
        {
            Name = request.Name
        });
    }
}

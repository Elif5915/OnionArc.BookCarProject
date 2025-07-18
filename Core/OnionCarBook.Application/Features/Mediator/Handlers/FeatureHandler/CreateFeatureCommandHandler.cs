﻿using MediatR;
using OnionCarBook.Application.Features.Mediator.Commands.FeatureCommand;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.FeatureHandler;
public class CreateFeatureCommandHandler : IRequestHandler<CreateFeatureCommand>
{
    private readonly IRepository<Feature> _repository;

    public CreateFeatureCommandHandler(IRepository<Feature> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateFeatureCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new Feature
        {
            Name = request.Name
        });
    }
}

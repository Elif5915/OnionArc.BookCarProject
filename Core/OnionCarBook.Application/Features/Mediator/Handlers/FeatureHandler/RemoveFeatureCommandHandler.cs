﻿using MediatR;
using OnionCarBook.Application.Features.Mediator.Commands.FeatureCommand;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.FeatureHandler;
public class RemoveFeatureCommandHandler : IRequestHandler<RemoveFeatureCommand>
{
    private readonly IRepository<Feature> _repository;

    public RemoveFeatureCommandHandler(IRepository<Feature> repository)
    {
        _repository = repository;
    }

    public async Task Handle(RemoveFeatureCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
    }
}

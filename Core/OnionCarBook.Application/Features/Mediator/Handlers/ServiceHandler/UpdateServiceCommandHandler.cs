﻿using MediatR;
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
public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand>
{
    private readonly IRepository<Service> _repository;

    public UpdateServiceCommandHandler(IRepository<Service> repository)
    {
        _repository = repository;
    }
    public async Task Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.ServiceId);
        values.Title = request.Title;
        values.Description = request.Description;
        values.IconUrl = request.IconUrl;
        await _repository.UpdateAsync(values);
    }
}

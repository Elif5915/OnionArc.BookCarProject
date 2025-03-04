﻿using MediatR;
using OnionCarBook.Application.Features.Mediator.Commands.FooterAddressCommand;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.Mediator.Handlers.FooterAddressHandler;
public class RemoveFooterAddressCommandHandler : IRequestHandler<RemoveFooterAddressCommand>
{
    private readonly IRepository<FooterAddress> _repository;

    public RemoveFooterAddressCommandHandler(IRepository<FooterAddress> repository)
    {
        _repository = repository;
    }

    public async Task Handle(RemoveFooterAddressCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
    }
}

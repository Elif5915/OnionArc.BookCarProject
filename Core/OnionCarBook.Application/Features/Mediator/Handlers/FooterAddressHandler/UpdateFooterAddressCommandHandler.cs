using MediatR;
using OnionCarBook.Application.Features.Mediator.Commands.FooterAddressCommand;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.Mediator.Handlers.FooterAddressHandler;
public class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
{
    private readonly IRepository<FooterAddress> _repository;

    public UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.FooterAddressId);
        values.Phone = request.Phone;
        values.Description = request.Description;
        values.Email = request.Email;
        values.Address = request.Address;
        await _repository.UpdateAsync(values);
    }
}

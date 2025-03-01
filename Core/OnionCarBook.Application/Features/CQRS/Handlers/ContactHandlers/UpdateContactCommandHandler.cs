using OnionCarBook.Application.Features.CQRS.Commands.BrandCommands;
using OnionCarBook.Application.Features.CQRS.Commands.ContactCommands;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.CQRS.Handlers.ContactHandlers;
public class UpdateContactCommandHandler
{
    private readonly IRepository<Contact> _repository;

    public UpdateContactCommandHandler(IRepository<Contact> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateContactCommand command)
    {
        var values = await _repository.GetByIdAsync(command.ContactId);
        values.Name = command.Name;
        values.Email = command.Email;
        values.SendDate = command.SendDate;
        values.Subject = command.Subject;
        values.Message = command.Message;

        await _repository.UpdateAsync(values);
    }
}

﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionCarBook.Application.Features.CQRS.Commands.ContactCommands;
using OnionCarBook.Application.Features.CQRS.Commands.ContactCommands;
using OnionCarBook.Application.Features.CQRS.Handlers.ContactHandlers;
using OnionCarBook.Application.Features.CQRS.Queries.ContactQueries;

namespace OnionCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ContactsController : ControllerBase
{
    private readonly CreateContactCommandHandler _createContactCommandHandler;
    private readonly GetContactByIdQueryHandler _getContactByIdQueryHandler;
    private readonly GetContactQueryHandler _getContactQueryHandler;
    private readonly RemoveContactCommandHandler _removeContactCommandHandler;
    private readonly UpdateContactCommandHandler _updateContactCommandHandler;

    public ContactsController(CreateContactCommandHandler createContactCommandHandler, GetContactByIdQueryHandler getContactByIdQueryHandler, GetContactQueryHandler getContactQueryHandler, RemoveContactCommandHandler removeContactCommandHandler, UpdateContactCommandHandler updateContactCommandHandler)
    {
        _createContactCommandHandler = createContactCommandHandler;
        _getContactByIdQueryHandler = getContactByIdQueryHandler;
        _getContactQueryHandler = getContactQueryHandler;
        _removeContactCommandHandler = removeContactCommandHandler;
        _updateContactCommandHandler = updateContactCommandHandler;
    }

    [HttpGet]
    public async Task<IActionResult> ContactList()
    {
        var values = await _getContactQueryHandler.Handle();
        return Ok(values);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetContact(int id)
    {
        var value = await _getContactByIdQueryHandler.Handle(new GetContactByIdQuery(id));
        return Ok(value);
    }
    [HttpPost]
    public async Task<IActionResult> CreateContact(CreateContactCommand command)
    {
        await _createContactCommandHandler.Handle(command);
        return Ok("İletişim Bilgisi Eklendi");
    }
    [HttpDelete]
    public async Task<IActionResult> RemoveContact(int id)
    {
        await _removeContactCommandHandler.Handle(new RemoveContactCommand(id));
        return Ok("Silme İşlemi Başarıyla Tamamlandı");
    }
    [HttpPut]
    public async Task<IActionResult> UpdateContact(UpdateContactCommand command)
    {
        await _updateContactCommandHandler.Handle(command);
        return Ok("İletişim bilgileri Güncellendi");
    }
}

﻿using OnionCarBook.Application.Features.CQRS.Queries.BrandQueries;
using OnionCarBook.Application.Features.CQRS.Queries.ContactQueries;
using OnionCarBook.Application.Features.CQRS.Results.BrandResult;
using OnionCarBook.Application.Features.CQRS.Results.ContactResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.CQRS.Handlers.ContactHandlers;
public class GetContactByIdQueryHandler
{
    private readonly IRepository<Contact> _repository;

    public GetContactByIdQueryHandler(IRepository<Contact> repository)
    {
        _repository = repository;
    }

    public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
    {
        var values = await _repository.GetByIdAsync(query.Id);
        return new GetContactByIdQueryResult
        {
            ContactId = values.ContactId,
            Name = values.Name,
            Email = values.Email,
            Subject = values.Subject,
            Message = values.Message,
            SendDate = values.SendDate
        };
    }
}

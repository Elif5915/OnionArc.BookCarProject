﻿using MediatR;
using OnionCarBook.Application.Features.Mediator.Queries.FooterAddressQueries;
using OnionCarBook.Application.Features.Mediator.Results.FooterAddressResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.Mediator.Handlers.FooterAddressHandler;
public class GetFooterAddressByIdQueryHandler : IRequestHandler<GetFooterAddressByIdQuery, GetFooterAddressByIdQueryResult>
{
    private readonly IRepository<FooterAddress> _repository;

    public GetFooterAddressByIdQueryHandler(IRepository<FooterAddress> repository)
    {
        _repository = repository;
    }

    public async Task<GetFooterAddressByIdQueryResult> Handle(GetFooterAddressByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        return new GetFooterAddressByIdQueryResult
        {
            Email = value.Email,
            Address = value.Address,
            Description = value.Description,
            FooterAddressId = value.FooterAddressId,
            Phone = value.Phone
        };
    }
}

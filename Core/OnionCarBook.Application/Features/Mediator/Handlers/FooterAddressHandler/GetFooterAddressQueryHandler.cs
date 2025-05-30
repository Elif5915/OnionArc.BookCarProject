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
public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQuery, List<GetFooterAddressQueryResult>>
{
    private readonly IRepository<FooterAddress> _repository;

    public GetFooterAddressQueryHandler(IRepository<FooterAddress> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetFooterAddressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x=>new GetFooterAddressQueryResult
        {
            Address = x.Address,
            Description = x.Description,
            Email = x.Email,
            Phone = x.Phone,
            FooterAddressId = x.FooterAddressId

        }).ToList();
    }
}

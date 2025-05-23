﻿using MediatR;
using OnionCarBook.Application.Features.Mediator.Queries.PricingQueries;
using OnionCarBook.Application.Features.Mediator.Results.PricingResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.Mediator.Handlers.PricingHandler;
public class GetPricingByIdQueryHandler : IRequestHandler<GetPricingByIdQuery, GetPricingByIdQueryResult>
{
    private readonly IRepository<Pricing> _repository;

    public GetPricingByIdQueryHandler(IRepository<Pricing> repository)
    {
        _repository = repository;
    }
    public async Task<GetPricingByIdQueryResult> Handle(GetPricingByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.Id);
        return new GetPricingByIdQueryResult
        {
            PricingId = values.PricingId,
            Name = values.Name
        };
    }
}

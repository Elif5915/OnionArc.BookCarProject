﻿using MediatR;
using OnionCarBook.Application.Features.Mediator.Queries.LocationQueries;
using OnionCarBook.Application.Features.Mediator.Results.LocationResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.Mediator.Handlers.LocationHandler;
public class GetTestimonialQueryHandler : IRequestHandler<GetLocationQuery, List<GetLocationQueryResult>>
{
    private readonly IRepository<Location> _repository;

    public GetTestimonialQueryHandler(IRepository<Location> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetLocationQueryResult
        {
            LocationId = x.LocationId,
            Name = x.Name
        }).ToList();
    }
}

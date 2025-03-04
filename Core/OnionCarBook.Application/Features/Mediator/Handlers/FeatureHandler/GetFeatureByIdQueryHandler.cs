﻿using MediatR;
using OnionCarBook.Application.Features.Mediator.Queries.FeatureQueries;
using OnionCarBook.Application.Features.Mediator.Results.FeatureResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.Mediator.Handlers.FeatureHandler;
public class GetFeatureByIdQueryHandler : IRequestHandler<GetFeatureByIdQuery, GetFeatureByIdQueryResult>
{
    private readonly IRepository<Feature> _repository;

    public GetFeatureByIdQueryHandler(IRepository<Feature> repository)
    {
        _repository = repository;
    }

    public async Task<GetFeatureByIdQueryResult> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.Id);
        return new GetFeatureByIdQueryResult
        {
            FeatureId = values.FeatureId,
            Name = values.Name
        };
    }
}

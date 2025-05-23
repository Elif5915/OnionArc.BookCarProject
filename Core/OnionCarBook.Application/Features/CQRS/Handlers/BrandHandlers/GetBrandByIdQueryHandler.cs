﻿using OnionCarBook.Application.Features.CQRS.Queries.BrandQueries;
using OnionCarBook.Application.Features.CQRS.Results.BrandResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.CQRS.Handlers.BrandHandlers;
public class GetBrandByIdQueryHandler
{
    private readonly IRepository<Brand> _repository;

    public GetBrandByIdQueryHandler(IRepository<Brand> repository)
    {
        _repository = repository;
    }

    public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery query)
    {
        var values = await _repository.GetByIdAsync(query.Id);
        return new GetBrandByIdQueryResult
        {
            BrandId = values.BrandId,
            Name = values.Name
        };
    }
}

﻿using OnionCarBook.Application.Features.CQRS.Queries.BrandQueries;
using OnionCarBook.Application.Features.CQRS.Queries.CategoryQueries;
using OnionCarBook.Application.Features.CQRS.Results.BrandResult;
using OnionCarBook.Application.Features.CQRS.Results.CategoryResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.CQRS.Handlers.CategoryHandlers;
public class GetCategoryByIdQueryHandler
{
    private readonly IRepository<Category> _repository;

    public GetCategoryByIdQueryHandler(IRepository<Category> repository)
    {
        _repository = repository;
    }
    public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
    {
        var values = await _repository.GetByIdAsync(query.Id);
        return new GetCategoryByIdQueryResult
        {
            CategoryId = values.CategoryId,
            Name = values.Name
        };
    }
}

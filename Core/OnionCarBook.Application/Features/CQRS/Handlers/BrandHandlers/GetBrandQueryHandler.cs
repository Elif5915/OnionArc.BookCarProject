﻿using OnionCarBook.Application.Features.CQRS.Results.BannerResult;
using OnionCarBook.Application.Features.CQRS.Results.BrandResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.CQRS.Handlers.BrandHandlers;
public class GetBrandQueryHandler
{
    private readonly IRepository<Brand> _repository;

    public GetBrandQueryHandler(IRepository<Brand> repository)
    {
        _repository = repository;
    }
    public async Task<List<GetBrandQueryResult>> Handle()
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetBrandQueryResult
        {
         BrandId = x.BrandId,
         Name = x.Name
         
        }).ToList();
    }
}

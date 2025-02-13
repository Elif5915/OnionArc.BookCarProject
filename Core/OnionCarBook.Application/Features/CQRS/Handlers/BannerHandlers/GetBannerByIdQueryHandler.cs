﻿using OnionCarBook.Application.Features.CQRS.Queries.BannerQueries;
using OnionCarBook.Application.Features.CQRS.Results.BannerResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.CQRS.Handlers.BannerHandlers;
public class GetBannerByIdQueryHandler
{
    private readonly IRepository<Banner> _repository;

    public GetBannerByIdQueryHandler(IRepository<Banner> repository)
    {
        _repository = repository;
    }

    public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query)
    {
        var values = await _repository.GetByIdAsync(query.Id);
        return new GetBannerByIdQueryResult
        {
            BannerId = values.BannerId,
            Title = values.Title,
            Description = values.Description,
            VideoDescription = values.VideoDescription,
            VideoUrl = values.VideoUrl
        };
    }
}


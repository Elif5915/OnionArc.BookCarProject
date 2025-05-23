﻿using MediatR;
using OnionCarBook.Application.Features.Mediator.Queries.LocationQueries;
using OnionCarBook.Application.Features.Mediator.Queries.SocialMediaQueries;
using OnionCarBook.Application.Features.Mediator.Results.LocationResult;
using OnionCarBook.Application.Features.Mediator.Results.SocialMediaResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.Mediator.Handlers.SocialMediaHandler;
public class GetSocialMediaByIdQueryHandler : IRequestHandler<GetSocialMediaByIdQuery, GetSocialMediaByIdQueryResult>
{
    private readonly IRepository<SocialMedia> _repository;

    public GetSocialMediaByIdQueryHandler(IRepository<SocialMedia> repository)
    {
        _repository = repository;
    }

    public async Task<GetSocialMediaByIdQueryResult> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.Id);
        return new GetSocialMediaByIdQueryResult
        {
            SocialMediaId = values.SocialMediaId,
            Name = values.Name,
            Url = values.Url,
            Icon = values.Icon
        };
    }
}

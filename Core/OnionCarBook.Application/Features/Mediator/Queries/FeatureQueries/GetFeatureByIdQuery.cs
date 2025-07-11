﻿using MediatR;
using OnionCarBook.Application.Features.Mediator.Results.FeatureResult;

namespace OnionCarBook.Application.Features.Mediator.Queries.FeatureQueries;
public class GetFeatureByIdQuery:IRequest<GetFeatureByIdQueryResult>
{
    public int Id { get; set; }

    public GetFeatureByIdQuery(int id)
    {
        Id = id;
    }
}

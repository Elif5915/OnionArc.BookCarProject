﻿using MediatR;
using OnionCarBook.Application.Features.Mediator.Results.FooterAddressResult;
using OnionCarBook.Application.Features.Mediator.Results.LocationResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.Mediator.Queries.LocationQueries;
public class GetLocationByIdQuery : IRequest<GetLocationByIdQueryResult>
{
    public int Id { get; set; }

    public GetLocationByIdQuery(int id)
    {
        Id = id;
    }
}

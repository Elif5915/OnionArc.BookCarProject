﻿using MediatR;
using OnionCarBook.Application.Features.Mediator.Results.PricingResult;
using OnionCarBook.Application.Features.Mediator.Results.ServiceResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.Mediator.Queries.ServiceQueries;
public class GetServiceQuery : IRequest<List<GetServiceQueryResult>>
{
}

﻿using MediatR;
using OnionCarBook.Application.Features.Mediator.Results.FeatureResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.Mediator.Queries.FeatureQueries;
public class GetFeatureQuery :IRequest<List<GetFeatureQueryResult>>
{
}

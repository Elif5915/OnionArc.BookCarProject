﻿using MediatR;
using OnionCarBook.Application.Features.Mediator.Results.BlogResult;

namespace OnionCarBook.Application.Features.Mediator.Queries.BlogQueries;
public class GetBlogQuery: IRequest<List<GetBlogQueryResult>>
{
}

using MediatR;
using OnionCarBook.Application.Features.Mediator.Results.LocationResult;
using OnionCarBook.Application.Features.Mediator.Results.SocialMediaResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.Mediator.Queries.SocialMediaQueries;
public class GetSocialMediaQuery : IRequest<List<GetSocialMediaQueryResult>>
{
}

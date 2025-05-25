using MediatR;
using OnionCarBook.Application.Features.Mediator.Results.TestimonialResult;

namespace OnionCarBook.Application.Features.Mediator.Queries.TestimonialQueries;
public class GetTestimonialQuery : IRequest<List<GetTestimonialQueryResult>>
{

}

using MediatR;
using OnionCarBook.Application.Features.Mediator.Results.TestimonialResult;

namespace OnionCarBook.Application.Features.Mediator.Queries.TestimonialQueries;
public class GetTestimonialByIdQuery : IRequest<GetTestimonialByIdQueryResult>
{
    public int Id { get; set; }

    public GetTestimonialByIdQuery(int id)
    {
        Id = id;
    }
}

using MediatR;
using OnionCarBook.Application.Features.Mediator.Queries.TestimonialQueries;
using OnionCarBook.Application.Features.Mediator.Results.TestimonialResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.TestimonialHandler;
public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
{
    private readonly IRepository<Testimonial> _repository;

    public GetTestimonialByIdQueryHandler(IRepository<Testimonial> repository)
    {
        _repository = repository;
    }

    public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.Id);
        return new GetTestimonialByIdQueryResult
        {
            TestimonialId = values.TestimonialId,
            Name = values.Name,
            Comment = values.Comment,
            ImageUrl = values.ImageUrl
        };
    }
}

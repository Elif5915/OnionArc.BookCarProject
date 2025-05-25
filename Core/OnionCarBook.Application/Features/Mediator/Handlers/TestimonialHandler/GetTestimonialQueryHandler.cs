using MediatR;
using OnionCarBook.Application.Features.Mediator.Queries.TestimonialQueries;
using OnionCarBook.Application.Features.Mediator.Results.TestimonialResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.TestimonialHandler;
public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
{
    private readonly IRepository<Testimonial> _repository;

    public GetTestimonialQueryHandler(IRepository<Testimonial> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetTestimonialQueryResult
        {
            TestimonialId = x.TestimonialId,
            Name = x.Name,
            Comment = x.Comment,
            Title = x.Title,
            ImageUrl = x.ImageUrl
        }).ToList();
    }
}

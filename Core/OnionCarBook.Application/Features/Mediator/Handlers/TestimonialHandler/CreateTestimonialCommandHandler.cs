using MediatR;
using OnionCarBook.Application.Features.Mediator.Commands.TestimonialCommand;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.TestimonialHandler;
public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommand>
{
    private readonly IRepository<Testimonial> _repository;

    public CreateTestimonialCommandHandler(IRepository<Testimonial> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new Testimonial
        {
            Name = request.Name,
            Title = request.Title,
            ImageUrl = request.ImageUrl,
            Comment = request.Comment
        });
    }
}

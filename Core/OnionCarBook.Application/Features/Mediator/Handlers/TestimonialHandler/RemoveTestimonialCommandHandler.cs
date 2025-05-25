using MediatR;
using OnionCarBook.Application.Features.Mediator.Commands.TestimonialCommand;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.TestimonialHandler;
public class RemoveTestimonialCommandHandler : IRequestHandler<RemoveTestimonialCommand>
{
    private readonly IRepository<Testimonial> _repository;

    public RemoveTestimonialCommandHandler(IRepository<Testimonial> repository)
    {
        this._repository = repository;
    }

    public async Task Handle(RemoveTestimonialCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
    }
}

using MediatR;
using OnionCarBook.Application.Features.Mediator.Commands.TestimonialCommand;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.TestimonialHandler;
public class UpdateTestimonialComandHandler : IRequestHandler<UpdateTestimonialCommand>
{
    private readonly IRepository<Testimonial> _repository;

    public UpdateTestimonialComandHandler(IRepository<Testimonial> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.TestimonialId);
        values.Name = request.Name;
        values.Title = request.Title;
        values.Comment = request.Comment;
        values.ImageUrl = request.ImageUrl;
        await _repository.UpdateAsync(values);
    }
}

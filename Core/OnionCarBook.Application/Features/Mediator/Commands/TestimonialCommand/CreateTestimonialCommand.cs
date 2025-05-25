using MediatR;

namespace OnionCarBook.Application.Features.Mediator.Commands.TestimonialCommand;
public class CreateTestimonialCommand : IRequest
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Comment { get; set; }
    public string ImageUrl { get; set; }
}

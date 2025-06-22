using MediatR;

namespace OnionCarBook.Application.Features.Mediator.Commands.FeatureCommand;
public class UpdateFeatureCommand :IRequest
{
    public int FeatureId { get; set; }
    public string Name { get; set; }
}

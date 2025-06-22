using MediatR;

namespace OnionCarBook.Application.Features.Mediator.Commands.FeatureCommand;
public class CreateFeatureCommand :IRequest
{
    //public int FeatureId { get; set; }
    public string Name { get; set; }
}

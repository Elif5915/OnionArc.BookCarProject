using MediatR;

namespace OnionCarBook.Application.Features.Mediator.Commands.SocialMediaCommand;
public class CreateSocialMediaCommand : IRequest
{
    public string Name { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
}

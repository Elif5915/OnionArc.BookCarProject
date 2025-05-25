using MediatR;

namespace OnionCarBook.Application.Features.Mediator.Commands.SocialMediaCommand;
public class UpdateSocialMediaCommand : IRequest
{
    public int SocialMediaId { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
}

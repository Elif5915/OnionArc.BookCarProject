using OnionCarBook.Application.Features.CQRS.Commands.BannerCommands;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.CQRS.Handlers.BannerHandlers;
public class CreateBannerCommandHandler
{
    private readonly IRepository<Banner> _repository;

    public CreateBannerCommandHandler(IRepository<Banner> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateBannerCommand command)
    {
        await _repository.CreateAsync(new Banner
        {
            Title = command.Title,
            Description = command.Description,
            VideoDescription = command.VideoDescription,
            VideoUrl = command.VideoUrl
        });
    }
}


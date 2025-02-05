using OnionCarBook.Application.Features.CQRS.Commands.AboutCommands;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.CQRS.Handlers.AboutHandlers;
public class UpdateAboutCommandHandler
{
    private readonly IRepository<About> _repository;

    public UpdateAboutCommandHandler(IRepository<About> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateAboutCommand command)
    {
        var values = await _repository.GetByIdAsync(command.AboutId);
        values.Description = command.Description;
        values.Title = command.Title;
        values.ImageUrl = command.ImageUrl;
        await _repository.UpdateAsync(values);
    }
}


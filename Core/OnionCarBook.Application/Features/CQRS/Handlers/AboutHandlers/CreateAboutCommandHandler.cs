﻿using OnionCarBook.Application.Features.CQRS.Commands.AboutCommands;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.CQRS.Handlers.AboutHandlers;
public class CreateAboutCommandHandler
{
    private readonly IRepository<About> _repository;

    public CreateAboutCommandHandler(IRepository<About> repository)
    {
        _repository = repository;
    }
    public async Task Handle(CreateAboutCommand command)
    {
        await _repository.CreateAsync(new About
        {
            Title = command.Title,
            Description = command.Description,
            ImageUrl = command.ImageUrl
        });
    }
}


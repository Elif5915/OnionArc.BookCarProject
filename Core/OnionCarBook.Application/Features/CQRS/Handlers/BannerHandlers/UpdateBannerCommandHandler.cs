﻿using OnionCarBook.Application.Features.CQRS.Commands.BannerCommands;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.CQRS.Handlers.BannerHandlers;
public class UpdateBannerCommandHandler
{
    private readonly IRepository<Banner> _repository;

    public UpdateBannerCommandHandler(IRepository<Banner> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateBannerCommand command)
    {
        var values = await _repository.GetByIdAsync(command.BannerId);
        values.Title = command.Title;
        values.Description = command.Description;
        values.VideoDescription = command.VideoDescription;
        values.VideoUrl = command.VideoUrl;
        await _repository.UpdateAsync(values);
    }
}


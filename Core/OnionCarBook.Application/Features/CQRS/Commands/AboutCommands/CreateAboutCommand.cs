﻿namespace OnionCarBook.Application.Features.CQRS.Commands.AboutCommands;
public class CreateAboutCommand
{
    // public int AboutId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}


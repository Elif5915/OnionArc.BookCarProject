﻿namespace OnionCarBook.Application.Features.CQRS.Results.AboutResult;
public class GetAboutQueryResult
{
    public int AboutId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}


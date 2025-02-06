﻿namespace OnionCarBook.Application.Features.CQRS.Results.BannerResult;
public class GetBannerByIdQueryResult
{
    public int BannerId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string VideoDescription { get; set; }
    public string VideoUrl { get; set; }
}


﻿namespace OnionCarBook.Application.Features.Mediator.Results.AuthorResult;
public class GetAuthorQueryResult
{
    public int AuthorId { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
}

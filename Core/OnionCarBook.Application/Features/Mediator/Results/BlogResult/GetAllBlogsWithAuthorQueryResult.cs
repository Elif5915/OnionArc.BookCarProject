﻿namespace OnionCarBook.Application.Features.Mediator.Results.BlogResult;
public class GetAllBlogsWithAuthorQueryResult
{
    public int BlogId { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public string AuthorName { get; set; }
    public string CategoryName { get; set; }
    public string CoverImageUrl { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CategoryId { get; set; }
    public string Description { get; set; }
}
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Results.BlogResult;
public class GetBlogQueryResult
{
    public int BlogId { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public string CoverImageUrl { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CategoryId { get; set; }
}

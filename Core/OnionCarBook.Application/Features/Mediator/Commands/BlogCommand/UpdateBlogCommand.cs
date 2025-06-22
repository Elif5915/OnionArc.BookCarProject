using MediatR;

namespace OnionCarBook.Application.Features.Mediator.Commands.BlogCommand;
public  class UpdateBlogCommand: IRequest
{
    public int BlogId { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public string CoverImageUrl { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CategoryId { get; set; }

}

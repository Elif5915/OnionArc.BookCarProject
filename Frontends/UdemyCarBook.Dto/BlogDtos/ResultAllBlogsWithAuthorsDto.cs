namespace UdemyCarBook.Dto.BlogDtos;
public class ResultAllBlogsWithAuthorsDto
{
    public int blogId { get; set; }
    public string title { get; set; }
    public int authorId { get; set; }
    public object authorName { get; set; }
    public object categoryName { get; set; }
    public string coverImageUrl { get; set; }
    public DateTime createdDate { get; set; }
    public int categoryId { get; set; }
}

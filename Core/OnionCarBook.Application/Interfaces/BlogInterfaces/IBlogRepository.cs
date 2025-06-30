using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Interfaces.BlogInterfaces;
public interface IBlogRepository
{
    public List<Blog> GetLast3BlogsWithAuthors();
    public List<Blog> GetAllBlogsWithAuthors();
}

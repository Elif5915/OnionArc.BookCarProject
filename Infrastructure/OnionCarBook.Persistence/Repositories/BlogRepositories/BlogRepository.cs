using Microsoft.EntityFrameworkCore;
using OnionCarBook.Application.Interfaces.BlogInterfaces;
using OnionCarBook.Domain.Entities;
using OnionCarBook.Persistence.Context;

namespace OnionCarBook.Persistence.Repositories.BlogRepositories;
public class BlogRepository : IBlogRepository
{
    private readonly CarBookContext _carBookContext;
    public BlogRepository(CarBookContext carBookContext)
    {
        _carBookContext = carBookContext;
    }
    public List<Blog> GetAllBlogsWithAuthors()
    {
       var values = _carBookContext.Blogs.Include(x => x.Author).ToList();
        return values;
    }
    public List<Blog> GetLast3BlogsWithAuthors()
    {
        var values = _carBookContext.Blogs.Include(x => x.Author).OrderByDescending(x => x.BlogId).Take(3).ToList();
        return values;
    }
}

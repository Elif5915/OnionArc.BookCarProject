namespace OnionCarBook.Application.Interfaces;
public interface IRepository<T> where T : class
{
    //repository mizin imzalarını burada tutuyoruz, bunları tüm entitylerimiz kullanabilir/ortak. 
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task RemoveAsync(T entity);
}

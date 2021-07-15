using Lab1WebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab1WebApi.Services
{
    public interface IBooksService
    {
        Task<Books.Book> AddBookAsync(Books.Book book);
        Task<Books.Book?> GetBookByIdAsync(int id);
        Task<IEnumerable<Books.Book>> GetBooksAsync();
    }
}
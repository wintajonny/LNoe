using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Lab1WebApi.Models.Books;

namespace Lab1WebApi.Services
{
    public class BooksService : IBooksService
    {


        private List<Book> _books = new();


        public BooksService()
        {
            if (_books.Count == 0)
            {
                InitBooks();
            }
        }

        private void InitBooks()
        {
            var books = Enumerable.Range(1, 20).Select(i => new Book($"title {i}", "sample publisher", i));
            _books.AddRange(books);
        }


        public Task<IEnumerable<Book>> GetBooksAsync()
        {
            return Task.FromResult<IEnumerable<Book>>(_books);
        }

        public Task<Book?> GetBookByIdAsync(int id)
        {
            return Task.FromResult(_books.SingleOrDefault(b => b.BookId == id));
        }

        public Task<Book> AddBookAsync(Book book)
        {
            Book newBook = book with { BookId = _books.Max(b => b.BookId) + 1 };
            _books.Add(newBook);
            return Task.FromResult(newBook);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1EFCore
{
    class Runner
    {
        private readonly BooksContext booksContext;

        public Runner(BooksContext booksContext)
        {
            this.booksContext = booksContext ?? throw new ArgumentNullException(nameof(booksContext));
        }

        public async Task CreateDataBaseAsync()
        {
            await booksContext.Database.EnsureCreatedAsync();
        }

        public void Query()
        {
            var books = booksContext.Books;

            foreach(var book in books)
            {
                Console.WriteLine($"Title:{book.Title}, Publisher: {book.Publisher}, ID: {book.Id}");
            }
        }

        public async Task WriteData(Book book)
        {
            await booksContext.Books.AddAsync(book);
            booksContext.SaveChanges();

            Console.WriteLine($"Book with ID {book.Id} added");
        }

        public void ClearDb()
        {
            booksContext.Books.RemoveRange(booksContext.Books);
            booksContext.SaveChanges();
        }

        public void GetAllBees()
        {
            var bees = booksContext.Books.Where(b => b.Title == "Bernhard Bienchen");
            foreach(var bee in bees)
            {
                Console.WriteLine(bee.Title + " " + bee.Id);
            }
        }

        public void GetIdsOver13Under18()
        {
            var idsOver13Under18 = booksContext.Books.Where(b => b.Id > 13 && b.Id < 18).OrderBy(b => b.Title);
            foreach(var item in idsOver13Under18)
            {
                Console.WriteLine(item.Id + " " + item.Title);
            }
        }

    }
}

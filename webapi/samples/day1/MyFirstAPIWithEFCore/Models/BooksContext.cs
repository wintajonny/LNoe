using Microsoft.EntityFrameworkCore;

namespace MyFirstAPI.Models
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options)
            : base(options)
        {

        }

        public DbSet<Book> Books => Set<Book>();
    }
}

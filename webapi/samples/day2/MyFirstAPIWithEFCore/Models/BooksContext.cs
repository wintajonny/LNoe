using Microsoft.EntityFrameworkCore;

namespace MyFirstAPI.Models
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(b => b.Publisher).HasMaxLength(30);
        }


        public DbSet<Book> Books => Set<Book>();
    }
}

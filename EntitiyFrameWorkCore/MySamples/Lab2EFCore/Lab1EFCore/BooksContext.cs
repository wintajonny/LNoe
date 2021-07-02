using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1EFCore
{
    class BooksContext : DbContext
    {

        public BooksContext(DbContextOptions<BooksContext> options) : base(options)
        {
        }

        public DbSet<Book> Books => Set<Book>();
        public DbSet<Author> Authors => Set<Author>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var authors = new[]
            {
                new Author("Thomas", "Winter"),
                new Author("Jonas", "Stadler"),
                new Author("Bernhard", "Piendl")
            };

            var books = Enumerable.Range(1, 20)
                .Select(i => new Book($"title {i}", "sample publisher", i).Author = authors[0] )
                .ToArray();
            modelBuilder.Entity<Book>().HasData(books);
            modelBuilder.Entity<Book>().Property(b => b.Title).HasMaxLength(150);

            

            modelBuilder.Entity<Author>().HasData(authors);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Books);




        }

    }
}

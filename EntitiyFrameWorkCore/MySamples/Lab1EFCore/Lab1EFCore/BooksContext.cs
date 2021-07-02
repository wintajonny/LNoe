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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var books = Enumerable.Range(1, 20)
                .Select(i => new Book($"title {i}", "sample publisher", i))
                .ToArray();
            modelBuilder.Entity<Book>().HasData(books);
            modelBuilder.Entity<Book>().Property(b => b.Title).HasMaxLength(150);
        }

    }
}

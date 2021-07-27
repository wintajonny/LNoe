using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

using System;
using System.Linq;

using var host = Host.CreateDefaultBuilder()
    .ConfigureServices((context, services) =>
    {
        var sqlConnection = context.Configuration.GetConnectionString("BooksConnection");
        services.AddDbContext<IBooksContext, BooksContext>(options =>
        {
            options.UseSqlServer(sqlConnection);
        });
        services.AddScoped<Runner>();
    }).Build();

var runner = host.Services.GetRequiredService<Runner>();
runner.CreateTheDatabase();
// runner.WriteData();
runner.ReadData();


public record Book(string Title, string Publisher, int BookId = 0);

public class BooksContext : DbContext, IBooksContext
{
    public BooksContext(DbContextOptions<BooksContext> options)
        : base(options)
    {
    }

    public DbSet<Book> Books => Set<Book>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var books = Enumerable.Range(1, 20)
            .Select(i => new Book($"title {i}", "sample pub", i))
            .ToArray();
        modelBuilder.Entity<Book>().HasData(books);
    }
    //public BooksContext()
    //{

    //}

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer(connectionString);
    //}
}

public class Runner
{
    private readonly IBooksContext _booksContext;
    public Runner(IBooksContext booksContext)
    {
        _booksContext = booksContext;
    }

    public void CreateTheDatabase()
    {
        _booksContext.Database.EnsureCreated();
    }

    public void WriteData()
    {
        Book book = new("Professional C#", "Wrox Press");
        _booksContext.Books.Add(book);
        int records = _booksContext.SaveChanges();
    }

    public void ReadData()
    {
        var books = _booksContext.Books;
        foreach (var book in books)
        {
            Console.WriteLine($"{book.Title} {book.Publisher}, {book.BookId}");
        }
    }
}

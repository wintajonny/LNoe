
using static System.Reflection.Metadata.BlobBuilder;

using var host = Host.CreateDefaultBuilder()
    .ConfigureServices((context, services) =>
    {
        var sqlConnection = context.Configuration.GetConnectionString("BooksConnection");
        services.AddDbContext<BooksContext>(options =>
        {
            options.UseSqlServer(sqlConnection);
        });
        services.AddScoped<Runner>();
    }).Build();

var runner = host.Services.GetRequiredService<Runner>();
runner.CreateTheDatabase();
// runner.WriteData();
// runner.ReadData();
await runner.QuerySampleAsync();

public record Book([property: MaxLength(30)]string Title, [property: StringLength(20)]string? Publisher, int BookId = 0);

public class BooksContext : DbContext
{
    public BooksContext(DbContextOptions<BooksContext> options)
        : base(options)
    {
    }

    public DbSet<Book> Books => Set<Book>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Book>()
        //    .Property(b => b.Title)
        //    .HasMaxLength(40)
        //    .IsRequired(true);
        //modelBuilder.Entity<Book>()
        //    .Property(b => b.Publisher)
        //    .HasMaxLength(15)
        //    .IsRequired(false);

        modelBuilder.ApplyConfiguration(new BookConfiguration());
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

internal class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.Property(b => b.Title)
            .HasMaxLength(40)
            .IsRequired(true);
        builder.Property(b => b.Publisher)
            .HasMaxLength(15)
            .IsRequired(false);
    }
}

public class Runner
{
    private readonly BooksContext _booksContext;
    public Runner(BooksContext booksContext) => 
        _booksContext = booksContext ?? throw new ArgumentNullException(nameof(booksContext));

    public void CreateTheDatabase() => 
        _booksContext.Database.EnsureCreated();

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

    public async Task QuerySampleAsync()
    {
        var book1 = await _booksContext.Books.FirstOrDefaultAsync(b => b.Title.StartsWith("Professional"));
        var book2 = await _booksContext.Books.FirstOrDefaultAsync(b => b.Publisher == "Wrox Press");


        if (object.ReferenceEquals(book1, book2))
        {
            Console.WriteLine("the same object");
        }
        else
        {
            Console.WriteLine("not the same object");
}
        string title = "sample";
        FormattableString s1 = $"a string {title}";
        s1.GetArguments()

       string s = $"SELECT * FROM Books WHERE TITLE = '{title}' ";

        var books = _booksContext.Books
            .FromSqlInterpolated($"SELECT * FROM Books WHERE TITLE = '{ title}'")
            .ToList();

    }

}

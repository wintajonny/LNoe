using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

public interface IBooksContext
{
    DbSet<Book> Books { get; }
    int SaveChanges();
    DatabaseFacade Database { get; }
}
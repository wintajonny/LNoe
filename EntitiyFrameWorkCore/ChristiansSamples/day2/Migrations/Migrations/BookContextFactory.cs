using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Migrations
{
    public class BookContextFactory : IDesignTimeDbContextFactory<BooksContext>
    {
        public BooksContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BooksContext>();
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb;database=ETCMigrationsSample;trusted_connection=true");

            return new BooksContext(optionsBuilder.Options);
        }
    }
}

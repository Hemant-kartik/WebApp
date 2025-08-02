using Microsoft.EntityFrameworkCore;

namespace WebApp.Data
{
    public class DBApp : DbContext
    {
        public DBApp(DbContextOptions<DBApp> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }  // Ensure to initialize the DbSet
        public DbSet<Language> Languages { get; set; }  // Ensure to initialize the DbSet
        public DbSet<BookPrice> BookPrices { get; set; }  // Ensure to initialize the DbSet
        public DbSet<Currency> Currencys { get; set; }  // Ensure to initialize the DbSet

    }
    
}

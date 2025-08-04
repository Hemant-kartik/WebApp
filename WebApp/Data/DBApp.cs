using Microsoft.EntityFrameworkCore;

namespace WebApp.Data
{
    public class DBApp : DbContext
    {
        public DBApp(DbContextOptions<DBApp> options) : base(options)
        {
        }

        // Configure your model using Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Currency>().HasData(
                new Currency { Id = 1, Title = "INR", Description = "Indian INR" },
                new Currency { Id = 2, Title = "Dollar", Description = "US Dollar" },
                new Currency { Id = 3, Title = "Euro", Description = "Euro" },
                new Currency { Id = 4, Title = "Dinar", Description = "Dinar" }
            );
        }

        // DbSets for your models
        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }
        public DbSet<Currency> Currencies { get; set; }
    }
}

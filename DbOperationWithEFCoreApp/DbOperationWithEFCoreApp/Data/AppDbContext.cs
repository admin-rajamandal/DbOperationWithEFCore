using Microsoft.EntityFrameworkCore;
using System.Data;

namespace DbOperationWithEFCoreApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> Options):base(Options)
        {
            
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<CurrencyType>().HasData(
        //        new CurrencyType { Id = 1, Title = "INR", Description = "Indian Rupee" },
        //        new CurrencyType { Id = 2, Title = "EUR", Description = "Euro" },
        //        new CurrencyType { Id = 3, Title = "GBP", Description = "British Pound" },
        //        new CurrencyType { Id = 4, Title = "USD", Description = "United States Dollar" }
        //    );

        //    modelBuilder.Entity<Language>().HasData(
        //        new Language { Id = 1, Title = "Hindi", Description = "Hindi Language" },
        //        new Language { Id = 2, Title = "English", Description = "English Language" },
        //        new Language { Id = 3, Title = "French", Description = "French Language" },
        //        new Language { Id = 4, Title = "Spanish", Description = "Spanish Language" },
        //        new Language { Id = 5, Title = "German", Description = "German Language" }
        //    );
        //}

        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }
        public DbSet<CurrencyType> CurrencyTypes { get; set; }


       
    }
}

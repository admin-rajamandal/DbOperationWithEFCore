using Microsoft.EntityFrameworkCore;

namespace DbOperationWithEFCoreApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> Options):base(Options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
namespace Fiorella.DAL
{
    public class AppDbContext : DbContext
    {
         public AbbDbContext(DbContextOptions<AppDbContext> options) : base(options)
         {

         }
         public DbSet<Product> Products { get; set; }
    }
}

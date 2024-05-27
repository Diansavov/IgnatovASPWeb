using Microsoft.EntityFrameworkCore;
using TestIgnatov.Models;

namespace TestIgnatov.Data
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set;}

    }
}
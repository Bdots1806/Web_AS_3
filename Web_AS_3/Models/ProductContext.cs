using Microsoft.EntityFrameworkCore;

namespace Web_AS_3.Models
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<DbContext> options): base(options)
        {

        }
        public DbSet<Product> Products { get; set;}
    }
}

using Microsoft.EntityFrameworkCore;

namespace Web_AS_3.Models
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set;}

       public DbSet<User> Users { get; set;}

       public DbSet<Comments> Comments { get; set;}
       public DbSet<Cart> Carts { get; set;}

    }
}

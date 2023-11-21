using Microsoft.EntityFrameworkCore;
using Product_Reviews_Api.Models;

namespace Product_Reviews_Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}

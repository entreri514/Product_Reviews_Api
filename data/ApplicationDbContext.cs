using Microsoft.EntityFrameworkCore;

namespace Product_Reviews_Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}

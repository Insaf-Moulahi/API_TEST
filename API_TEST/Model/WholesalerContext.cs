using Microsoft.EntityFrameworkCore;
namespace API_TEST.Model
{
    public class WholesalerContext : DbContext
    {
        public WholesalerContext(DbContextOptions<WholesalerContext> options) : base(options)
        { }
        public DbSet<Wholesaler> Wholesalers { get; set; }
    }
}

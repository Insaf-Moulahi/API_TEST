using Microsoft.EntityFrameworkCore;

namespace API_TEST.Model
{
    public class Wholesaler_StockContext : DbContext
    {
        public Wholesaler_StockContext(DbContextOptions<Wholesaler_StockContext> options) : base(options)
        { }
        public DbSet<Wholesaler_Stock> Wholesalers_Stock { get; set; }
    }
}

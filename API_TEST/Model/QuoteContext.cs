using Microsoft.EntityFrameworkCore;

namespace API_TEST.Model
{
    public class QuoteContext : DbContext
    {
        public QuoteContext(DbContextOptions<BeerContext> options) : base(options)
        { }
        public DbSet<Beer> Beers { get; set; }
    }
}

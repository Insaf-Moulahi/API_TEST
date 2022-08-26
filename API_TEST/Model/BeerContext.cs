using Microsoft.EntityFrameworkCore;

namespace API_TEST.Model
{
    public class BeerContext: DbContext
    {
        public BeerContext(DbContextOptions<QuoteContext> options) : base(options)
        { }
        public DbSet<Quote> Quotes { get; set; }
    }
}

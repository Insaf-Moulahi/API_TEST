using Microsoft.EntityFrameworkCore;

namespace API_TEST.Model
{
    public class BreweryContexDbContextt : DbContext
    {
        public BreweryContexDbContextt(DbContextOptions<BreweryContexDbContextt> options) : base(options)
        { }
        public DbSet<Brewery>Breweries{get; set;}
    }
}

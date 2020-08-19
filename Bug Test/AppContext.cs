using Microsoft.EntityFrameworkCore;

namespace Bug_Test
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    }
}

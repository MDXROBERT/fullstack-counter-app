using Microsoft.EntityFrameworkCore;

namespace CounterAPI
{
    public class AppDbContext : DbContext // inherets from the microsoft class for connecting to databases
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) // options contains settings for which file to connect to, and : base(options) pases settings to DbContext.
        {
        }

        public DbSet<F1Car> F1Cars { get; set; } // DbSet is the table where each row is a Car Object F1Cars is the name of the table
    }
}
using Microsoft.EntityFrameworkCore;

namespace asp.net_Project.Models
{
    public class StepsDbContext : DbContext
    {
        public StepsDbContext(DbContextOptions<StepsDbContext> options) : base(options)
        {

        }
        public DbSet<StepsModel> StepsM { get; set; }
    }
}

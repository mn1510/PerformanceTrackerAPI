using Microsoft.EntityFrameworkCore;
using PerformanceTrackerAPI.Entities;

namespace PerformanceTrackerAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}

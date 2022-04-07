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
        public DbSet<ParameterAllowedType> AllowedType { get; set; }
        public DbSet<ParameterAllowedValue> AllowedValue { get; set; }
        public DbSet<ParameterLogging> ParameterLog { get; set; }
        public DbSet<SubActivity> SubActivity { get; set; }
        public DbSet<SubActivityParameter> SubActivityParameter { get; set; }

    }
}

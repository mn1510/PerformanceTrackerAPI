using Microsoft.EntityFrameworkCore;
using PerformanceTrackerAPI.Data;
using PerformanceTrackerAPI.Interfaces;
using PerformanceTrackerAPI.Services;

namespace PerformanceTrackerAPI.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration _config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite(_config.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}

using PerformanceTrackerAPI.Entities;

namespace PerformanceTrackerAPI.Interfaces
{
    public interface ITokenService
    {
        public string CreateToken(AppUser user);
    }
}

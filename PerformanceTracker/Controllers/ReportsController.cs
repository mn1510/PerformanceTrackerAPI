using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PerformanceTrackerAPI.Controllers
{
    public class ReportsController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<string>> GetReport()
        {
            return "Report generation in progress...";
        }
    }
}
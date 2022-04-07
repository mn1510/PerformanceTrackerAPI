using System.ComponentModel.DataAnnotations.Schema;

namespace PerformanceTrackerAPI.Entities
{
    public class SubActivity
    {
        public int Id { get; set; }
        public string SubActivityName { get; set; }
        [ForeignKey("ActivityId")]
        public Activity Activity { get; set; }
    }
}

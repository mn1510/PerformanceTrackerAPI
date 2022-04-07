using System.ComponentModel.DataAnnotations.Schema;

namespace PerformanceTrackerAPI.Entities
{
    public class SubActivityParameter
    {
        public int Id { get; set; }
        public string ParameterName { get; set; }
        public string ParameterDescription { get; set; }

        [ForeignKey("SubActivityId")]
        public SubActivity SubActivity { get; set; }
    }
}

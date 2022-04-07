using System.ComponentModel.DataAnnotations.Schema;


namespace PerformanceTrackerAPI.Entities
{
    public class ParameterLogging
    {
        public int Id { get; set; }
        public int LogEntryId{ get; set; }
        [ForeignKey("SubActivityId")]
        public SubActivity SubActivity { get; set; }
        [ForeignKey("ParameterAllowedTypeId")]
        public ParameterAllowedType ParameterAllowedType { get; set; }
        [ForeignKey("ParameterAllowedValueId")]
        public ParameterAllowedValue ParameterAllowedValue { get; set; }
        public string LogValue { get; set; }
        
        [ForeignKey("UserId")]
        public AppUser User{ get; set; }
    }
}

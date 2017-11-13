using System.ComponentModel.DataAnnotations;

namespace ProjectMeasurement.Models
{
    public class ProjectTask
    {
        public long? TaskId { get; set; }

        [MaxLength(100), Required]
        public string TaskName { get; set; }

        public virtual Project Project { get; set; }
        public virtual ProjectMember ProjectMember { get; set; }
    }
}

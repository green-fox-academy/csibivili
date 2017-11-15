using System.ComponentModel.DataAnnotations;

namespace ProjectMeasurement.Models
{
    public class ProjectTask
    {
        [Key]
        public long TaskId { get; set; }

        [MaxLength(100), Required]
        public string TaskName { get; set; }

        public Project Project { get; set; }
        public ProjectMember ProjectMember { get; set; }
    }
}

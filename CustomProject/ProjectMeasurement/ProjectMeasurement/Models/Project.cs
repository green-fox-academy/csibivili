using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectMeasurement.Models
{
    public class Project
    {
        [Key]
        [MaxLength(100), Required]
        public string ProjectName { get; set; }

        public ICollection<ProjectMember> ProjectMembers { get; set; }
        public ICollection<ProjectTask> ProjectTasks { get; set; }
    }
}

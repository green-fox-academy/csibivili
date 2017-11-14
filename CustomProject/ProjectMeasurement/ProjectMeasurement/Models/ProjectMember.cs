using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectMeasurement.Models
{
    public class ProjectMember
    {
        [Key]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "I think it is not an email address.")]
        public string EmailAddress { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<ProjectTask> ProjectTasks { get; set; }
    }
}

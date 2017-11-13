using System.ComponentModel.DataAnnotations;

namespace ProjectMeasurement.Models
{
    public class ProjectMember
    {
        public long? MemberId { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "I think it is not an email address.")]
        public string EmailAddress { get; set; }
    }
}

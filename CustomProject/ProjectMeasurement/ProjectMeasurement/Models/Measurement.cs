using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectMeasurement.Models
{
    public class Measurement
    {
        [Key]
        public long MeasurementId { get; set; }
        
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }

        public ProjectMember ProjectMember { get; set; }
        public ProjectTask ProjectTask { get; set; }
    }
}

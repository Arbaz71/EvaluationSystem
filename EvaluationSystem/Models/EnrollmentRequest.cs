using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Models
{
    public class EnrollmentRequest
    {
        [Key]
        public int EnrollmentRequestId { get; set; }
        public bool EnrollmentRequests { get; set; }
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; }
    }
}

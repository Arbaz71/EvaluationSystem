using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Models
{
    public class StudentLeaveRequest
    {
        [Key]
        public int StudentLeaveRequestId { get; set; }

        [Required]
        public string Reason { get; set; }

        public DateTime RequestDate { get; set; }

        public bool IsApproved { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}

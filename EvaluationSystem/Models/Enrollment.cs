using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public bool IsRequest { get; set; }

        public int CourseCode { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public virtual Student Student { get; set; }

        public virtual Course Course { get; set; }
    }
}

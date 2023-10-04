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

        public string CourseCode { get; set; }
        public string CourseName { get; set; }  
        public int Credit { get; set; } 

        public DateTime EnrollmentDate { get; set; }
        public string InstructorName { get; set; }  

        public virtual Student Student { get; set; }

        public virtual Course Course { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}

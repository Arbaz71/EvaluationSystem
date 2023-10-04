using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Models
{
    public class CourseStudent
    {
        [Key]
        public int CourseStudentId { get; set; }
        public string CourseCode { get; set; }
        public Course Course { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

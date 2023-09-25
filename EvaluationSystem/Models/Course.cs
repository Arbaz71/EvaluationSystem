using EvaluationSystem.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluationSystem.Models
{
    public class Course
    {
        [Key]
        
        public int CourseCode { get; set; }
        public string CourseName { get; set; }
        public int Credit { get; set; }
        public CourseType CourseType { get; set; }
        public Semester Semester { get; set; }
        public Instructor Instructor { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

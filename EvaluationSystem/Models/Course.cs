using EvaluationSystem.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluationSystem.Models
{
    public class Course
    {
        public int CourseCode { get; set; }
        public string CourseName { get; set; }
        public int Credit { get; set; }
        public CourseType CourseType { get; set; }
        [ForeignKey(nameof(SemesterId))]
        public int SemesterId { get; set; }
        public Semester Semester { get; set; }
    }
}

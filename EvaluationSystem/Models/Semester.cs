using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Models
{
    public class Semester
    {
        [Key]
        public int SemesterId { get; set; }
        public string SemesterName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Course> Courses { get; set; }

    }
}

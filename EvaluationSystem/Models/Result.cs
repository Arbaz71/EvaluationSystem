using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluationSystem.Models
{
    public class Result
    {
        [Key]
        public int ResultId { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public string CourseName { get; set; }
        public double Score { get; set; }
        public Student Student { get; set; }
    }
}

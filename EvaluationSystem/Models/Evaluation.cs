using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Models
{
    public class Evaluation
    {
        [Key]
        public int EvaluationId { get; set; }

        public double Score { get; set; }

        public DateTime EvaluationDate { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

        public int InstructorId { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}

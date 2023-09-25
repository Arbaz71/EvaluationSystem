using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Models
{
    public class Instructor
    {
        [Key]
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
        public byte[] ProfilePicture { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }    
        public bool IsResigned { get; set; }
        public int? CourseCode { get; set; }
        public Course Course { get; set; }
        public virtual ICollection<Survey> Surveys { get; set; }

        public virtual ICollection<Result> EvaluationResults { get; set; }
    }
}

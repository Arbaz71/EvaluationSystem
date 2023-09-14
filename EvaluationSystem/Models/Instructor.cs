using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Models
{
    public class Instructor
    {
        [Key]
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
        public bool SendResignationRequest { get; set; }
        public byte[] ProfilePicture { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public DateTime CreatedAt { get;set; }
        public DateTime UpdatedAt { get;set; }

    }
}

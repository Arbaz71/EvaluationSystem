using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        [Required]
        public string Email { get; set; }

        public byte[] ProfilePicture { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public bool IsDeleted { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public virtual ICollection<Evaluation> Evaluations { get; set; }
    }
}

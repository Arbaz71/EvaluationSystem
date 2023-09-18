using EvaluationSystem.Enum;
using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public UserRole userRole { get; set; } = UserRole.Student;
    }
}

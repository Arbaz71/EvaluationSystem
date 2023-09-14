using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Models
{
    public class DepartmentManager
    {
        [Key]
        public int DepartmentManagerId { get; set; }    
        public byte[] ProfilePicture { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public Admin Admin { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<Instructor>Instructors { get; set; }
        
    }
}

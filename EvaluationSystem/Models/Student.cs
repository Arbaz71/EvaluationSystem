using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluationSystem.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public byte[] ProfilePicture { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public Result Result { get; set; }
        [ForeignKey("Admin")]
        public int AdminId { set; get; }
        
    }
}

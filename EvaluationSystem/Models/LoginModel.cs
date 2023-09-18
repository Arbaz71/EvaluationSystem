using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Models
{
    public class LoginModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

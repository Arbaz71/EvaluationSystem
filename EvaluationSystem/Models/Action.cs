using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Models
{
    public class Action
    {
        [Key]
        public int ActionId { get; set; }   
        public bool IsAccepted { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Models
{
    public class Choice
    {
        [Key]
        public int ChoiceId { get; set; }
        public string Text { get; set; }
        public Question Question { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Models
{
    public class Question
    {
        [Key]
        public int QuestionNo { get; set; }
        public string Text { get; set; }
        public List<Choice> Choices { get; set; }

        public Question()
        {
            Choices = new List<Choice>();
        }
    }
}

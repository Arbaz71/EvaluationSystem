namespace EvaluationSystem.Models
{
    public class Question
    {
        public int QuestionNo { get; set; }
        public string Text { get; set; }
        public List<Choice> Choices { get; set; }

        public Question()
        {
            Choices = new List<Choice>();
        }
    }
}

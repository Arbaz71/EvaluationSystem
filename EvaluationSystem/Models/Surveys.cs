using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Models
{
    public class Surveys
    {
        [Key]
        public int SurveyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Question> Questions { get; set; }


    }
}

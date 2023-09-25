using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Models
{
    public class SurveyQuestion
    {
        [Key]
        public int SurveyQuestionId { get; set; }
        [Required]
        public string QuestionText { get; set; }

        public virtual Survey Survey { get; set; }

        public virtual ICollection<SurveyResponse> SurveyResponses { get; set; }
    }
}

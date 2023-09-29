using EvaluationSystem.Models;

namespace EvaluationSystem.DTO
{
    public class GetSemesterDto
    {
        public string SemesterName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Course> Classes { get; set; }
    }
}

namespace EvaluationSystem.DTO
{
    public class CreateSemesterDto
    {
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set;}
        public string Name { get; set;}
    }
}

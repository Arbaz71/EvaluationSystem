namespace EvaluationSystem.DTO
{
    public class UnRegisterDto
    {
        public string CourseName { get; set; }  
        public string CourseCode { get; set; } 
        public int Credit { get; set; }
        public string InstructorName { get; set; }
        public bool IsRegistered { get; set; }  
    }
}

using EvaluationSystem.Enum;

namespace EvaluationSystem.DTO
{
    public class AddCourseDto
    {
        public string CourseName { get;set; }
        public string CourseCode { get;set; }
        public int Credit { get;set; }
        public CourseType CourseType { get;set; }
        public string SemesterName { get;set; }
    }
}

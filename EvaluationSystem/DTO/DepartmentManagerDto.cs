using EvaluationSystem.Enum;

namespace EvaluationSystem.DTO
{
    public class DepartmentManagerDto
    {
        public string CourseName { get; set; }
        public int CourseCode { get; set; }
        public int Credit { get; set; }
        public string InstructorName { get; set; }
        public CourseType CourseType { get; set; }
        public string SemesterName { get; set; }
        public string EnrollStudent { get; set; }
        public DMAction Action { get; set; }

    }
}

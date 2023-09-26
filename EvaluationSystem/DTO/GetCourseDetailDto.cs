using EvaluationSystem.Enum;
using EvaluationSystem.Models;

namespace EvaluationSystem.DTO
{
    public class GetCourseDetailDto
    {
        public string CourseName { get; set; }
        public int CourseCode { get; set; }
        public int Credit { get; set; }
        public CourseType CourseType { get; set; }
        public string InstructorName { get; set; }
        public string SemesterName { get; set; }
        public List<Enrollment> StudentName {  get; set; }

    }
}

using EvaluationSystem.Enum;
using EvaluationSystem.Models;

namespace EvaluationSystem.DTO
{
    public class GetCourseDetailDto
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public int Credit { get; set; }
        public CourseType CourseType { get; set; }
        public string InstructorName { get; set; }
        public string SemesterName { get; set; }
        public List<Enrollment> StudentName {  get; set; }

    }
}

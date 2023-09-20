using EvaluationSystem.Models;

namespace EvaluationSystem.Services.CourseServices
{
    public interface ICourseService
    {
        IEnumerable<Course> GetAllCourses();
        void AddCourse(Course course);
        
    }
}

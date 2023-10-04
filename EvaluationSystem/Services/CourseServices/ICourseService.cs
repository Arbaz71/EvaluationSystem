using EvaluationSystem.DTO;
using EvaluationSystem.Models;

namespace EvaluationSystem.Services.CourseServices
{
    public interface ICourseService
    {
        Task<IEnumerable<GetCourseDetailDto>> GetAllCoursesAsync();
        Task<Course> AddCourseAsync(AddCourseDto addCourse);


    }
}

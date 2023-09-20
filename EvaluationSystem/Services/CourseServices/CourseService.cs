using EvaluationSystem.Data;
using EvaluationSystem.Models;

namespace EvaluationSystem.Services.CourseServices
{
    public class CourseService:ICourseService
    {
        private readonly ApplicationDbContext _context;
        public CourseService(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Course> GetAllCourses()
        {
            return _context.Courses.ToList();
        }
        public void AddCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }
       

    }
}

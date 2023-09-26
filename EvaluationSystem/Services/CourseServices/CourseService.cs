using EvaluationSystem.Data;
using EvaluationSystem.DTO;
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
        public async Task<IEnumerable<GetCourseDetailDto>> GetAllCoursesAsync()
        {
            var course = await _context.Courses
                .Select(course=> new GetCourseDetailDto
                {

                    CourseCode= course.CourseCode,
                    CourseName= course.CourseName,
                    Credit= course.Credit,
                    InstructorName=course.InstructorName,
                    CourseType= course.CourseType,
                    SemesterName= course.SemesterName,
                    

                }
                )

        }
        public async Task<int> AddCourseAsync(AddCourseDto addCourse)
        {
            var course = new Course
            {
                CourseCode = addCourse.CourseCode,
                CourseName = addCourse.CourseName,
                Credit = addCourse.Credit,
                CourseType = addCourse.CourseType,
                SemesterName = addCourse.SemesterName
            };
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
        }
       

    }
}

using EvaluationSystem.Data;
using EvaluationSystem.DTO;
using Microsoft.EntityFrameworkCore;

namespace EvaluationSystem.Services.RegisterStudentServices
{
    public class RegisterStudentService:IRegisterStudentService
    {
        private readonly ApplicationDbContext _context;
        public RegisterStudentService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<object> GetRegisterStudentAsync()
        {
            var register = await _context.Enrollments
                .Select(register => new RegisterDto
                {
                    CourseCode = register.CourseCode,
                    CourseName = register.CourseName,
                    Credit = register.Credit,
                    InstructorName = register.InstructorName
                }).ToListAsync();

            return register;
        }


    }
}

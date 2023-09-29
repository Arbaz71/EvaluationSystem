using EvaluationSystem.Data;
using EvaluationSystem.DTO;
using Microsoft.EntityFrameworkCore;


namespace EvaluationSystem.Services.SemesterServices
{
    public class SemesterService:ISemesterService
    {
        private readonly ApplicationDbContext _context;

        public SemesterService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<object> GetAllSemesterAsync()
        {
            var semester = await _context.Semesters
                .Select(semester => new GetSemesterDto
                {
                    SemesterName = semester.SemesterName,
                    StartDate = semester.StartDate,
                    EndDate = semester.EndDate,
                    Classes = semester.Courses.ToList()
                }).ToListAsync();
            return semester;
        }


    }
}

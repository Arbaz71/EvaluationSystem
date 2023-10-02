using EvaluationSystem.Data;
using EvaluationSystem.DTO;
using EvaluationSystem.Models;
using Microsoft.EntityFrameworkCore;


namespace EvaluationSystem.Services.SemesterServices
{
    public class SemesterService : ISemesterService
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
        public async Task<object> AddSemesterAsync(CreateSemesterDto addSemester)
        {
            var semester = new Semester
            {
                SemesterName = addSemester.SemesterName,
                StartDate = addSemester.StartDate,
                EndDate = addSemester.EndDate
            };
              _context.Semesters.Add(semester);
            await _context.SaveChangesAsync();
            return semester;

        }

    }
}

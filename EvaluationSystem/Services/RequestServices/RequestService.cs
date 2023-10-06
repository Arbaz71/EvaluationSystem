using EvaluationSystem.Data;
using EvaluationSystem.DTO;
using Microsoft.EntityFrameworkCore;

namespace EvaluationSystem.Services.RequestServices
{
    public class RequestService : IRequestService
    {
        private readonly ApplicationDbContext _context;

        public RequestService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<object> GetAllRequestAsync()
        {
            var request = await _context.Enrollments
                .Select(request => new EnrollRequestDto
                {
                    StudentName = request.StudentName,
                    IsRequest = request.IsRequest,
                }).ToListAsync();
            return request;
        }
        public async Task<object> SendRequestAsync()
        {
            var request = await _context.Enrollments
                .Select(request => new EnrollRequestDto
                {
                    StudentName = request.StudentName,
                    IsRequest = request.IsRequest
                }).ToListAsync();
            return request;
        }

    }
}


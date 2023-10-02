using EvaluationSystem.DTO;

namespace EvaluationSystem.Services.SemesterServices
{
    public interface ISemesterService
    {
        Task<object> GetAllSemesterAsync();
        Task<object> AddSemesterAsync(CreateSemesterDto addSemester);
    }
}

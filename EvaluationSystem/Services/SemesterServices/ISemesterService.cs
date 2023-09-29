using EvaluationSystem.DTO;

namespace EvaluationSystem.Services.SemesterServices
{
    public interface ISemesterService
    {
        Task<IEnumerable<GetSemesterDto>> GetAllSemesterAsync();
        Task<object> AddSemesterAsync(CreateSemesterDto addSemester);
    }
}

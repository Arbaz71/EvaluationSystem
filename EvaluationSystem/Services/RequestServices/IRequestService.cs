namespace EvaluationSystem.Services.RequestServices
{
    public interface IRequestService
    {
        Task<object> SendRequestAsync();
        Task<object> GetAllRequestAsync();
    }
}

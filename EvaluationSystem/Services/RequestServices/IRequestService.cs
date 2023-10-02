namespace EvaluationSystem.Services.RequestServices
{
    public interface IRequestService
    {
        Task<object> SendRequestAsync();
    }
}

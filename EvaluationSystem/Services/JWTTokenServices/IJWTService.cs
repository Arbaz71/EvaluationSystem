
namespace EvaluationSystem.Services.JWTTokenServices
{
    public interface IJWTService
    {
        string GenerateToken(string userId, string userRole);
    }

}

using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EvaluationSystem.Services.JWTTokenServices
{
    public class JWTService : IJWTService
    {
        //private readonly string _jwtSecret;
        private readonly SymmetricSecurityKey _jwtKey;
        private readonly double _jwtDurationDays;

        public JWTService(string jwtSecret, double jwtDurationDays)
        {
            byte[] secretBytes = Convert.FromBase64String(jwtSecret);
            _jwtKey = new SymmetricSecurityKey(secretBytes);
            _jwtDurationDays = jwtDurationDays;
        }
        public string GenerateToken(string userId, string userRole)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, userId),
                    new Claim(ClaimTypes.Role, userRole),
                }),
                Expires = DateTime.UtcNow.AddMinutes(_jwtDurationDays),
                SigningCredentials = new SigningCredentials(_jwtKey, SecurityAlgorithms.HmacSha256Signature),
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}

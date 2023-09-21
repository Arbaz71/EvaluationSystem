using EvaluationSystem.Services.JWTTokenServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EvaluationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IJWTService _jwtTokenService;

        public UserController(IJWTService jwtTokenService)
        {
            _jwtTokenService = jwtTokenService;
        }
        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] Models.LoginModel loginModel)
        {
            try
            {
                string userId;
                string userRole;

                if (loginModel.UserName == "Admin" && loginModel.Password == "123qwe")
                {
                    userId = "1111111111";
                    userRole = "Admin";
                }

                else if (loginModel.UserName == "Instructor" && loginModel.Password == "123qwe")
                {
                    userId = "2222222222";
                    userRole = "Instructor";
                }

                else if (loginModel.UserName == "DepartmentManager" && loginModel.Password == "123qwe")
                {
                    userId = "4444444444";
                    userRole = "DepartmentManager";
                }
                else if (loginModel.UserName == "Student" && loginModel.Password == "123qwe")
                {
                    userId = "3333333333";
                    userRole = "Student";
                }
                else
                {
                    return Unauthorized("Invalid Credentials");
                }

                var token = _jwtTokenService.GenerateToken(userId, userRole);

                return Ok(new { Token = token });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

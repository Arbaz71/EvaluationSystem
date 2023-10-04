using EvaluationSystem.Services.RegisterStudentServices;
using Microsoft.AspNetCore.Mvc;

namespace EvaluationSystem.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IRegisterStudentService _registerStudentService;

        public StudentController(IRegisterStudentService registerStudentService)
        {
            _registerStudentService = registerStudentService;
        }

        [HttpGet("RegisterStudentRecord")]
        public IActionResult GetRegisterStudentRecord()
        {
            try
            {
                var registerstudent = _registerStudentService.GetRegisterStudentAsync();
                return Ok(registerstudent);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

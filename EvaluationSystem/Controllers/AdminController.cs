using EvaluationSystem.DTO;
using EvaluationSystem.Models;
using EvaluationSystem.Services.CourseServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace EvaluationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class AdminController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public AdminController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet("courses")]
        public IActionResult GetAllCourses()
        {
            try
            {
                var courses= _courseService.GetAllCourses();
                return Ok(courses);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("Add")]
        public IActionResult AddCourses([FromBody] AddCourseDto course)
        {
            try
            {
                if (course == null)
                {
                    return BadRequest("Course not found");
                }
                _courseService.AddCourseDto(course);
                return Ok(course);
                    
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

using EvaluationSystem.DTO;
using EvaluationSystem.Models;
using EvaluationSystem.Services.CourseServices;
using EvaluationSystem.Services.RequestServices;
using EvaluationSystem.Services.SemesterServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EvaluationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]//[Authorize]

    public class AdminController : ControllerBase
    {
        private readonly ICourseService _courseService;
        private readonly ISemesterService _semesterService;
        private readonly IRequestService _requestService;
        public AdminController(ICourseService courseService, ISemesterService semesterService, IRequestService requestService)
        {
            _courseService = courseService;
            _semesterService = semesterService;
        }
        [HttpGet("courses")]
        public IActionResult GetAllCourses()
        {
            try
            {
                var courses = _courseService.GetAllCoursesAsync();
                return Ok(courses);
            }
            catch (Exception ex)
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
                _courseService.AddCourseAsync(course);
                return Ok(course);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetSemesters")]
        public IActionResult GetAllSemester()
        {
            try
            {
                var semesters = _semesterService.GetAllSemesterAsync();
                return Ok(semesters);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("AddSemester")]
        public async Task<object> AddSemesterAsync([FromBody] CreateSemesterDto addSemester)
        {
            try
            {
                if (addSemester == null)
                {
                    return BadRequest("Smesters not Foumd");
                }
              await _semesterService.AddSemesterAsync(addSemester);
                return Ok(addSemester);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetEnrollmentRequest")]
        public async Task<object> GetAllRequest()
        {
            try
            {
                var enrollrequest= await _requestService.GetAllRequestAsync();  
                return Ok(enrollrequest);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}

using AcademyWeb.Abstractions;
using DataProvider.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AcademyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        // GET: api/<StudentController>
        [HttpGet]
        public IActionResult GetStudents()
        {
            var list = _studentService.GetStudents();

            return Ok(list);
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {   
            return Ok();   
        }

        // POST api/<StudentController>
        [HttpPost]
        public IActionResult AddStudent([FromBody] Student student)
        {
            return Ok();
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

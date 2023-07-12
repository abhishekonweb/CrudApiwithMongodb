using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Services;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentServices _studentServices;
        public StudentController(IStudentServices studentservices)
        {
            _studentServices = studentservices;
        }


        
        [HttpGet("GetStudents")]

        public ActionResult<List<Student>> Get()
        {
            return _studentServices.GetStudents();
        }


        [HttpGet("{id}")]
        public ActionResult<Student>GetStudent(string id)
        {
            return _studentServices.GetStudent(id);
        }

        [HttpPost("AddStudent")]
        public ActionResult<Student> Post(Student student)
        {
            _studentServices.Create(student);
            return CreatedAtAction(nameof(Get),new { id=student.Id}, student);
        }

        [HttpPut("{id}")]
        public void  Update(string id ,Student student) 
            
            { 
            _studentServices.Update(id, student);
            }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _studentServices.Delete(id);
        }
    }
}

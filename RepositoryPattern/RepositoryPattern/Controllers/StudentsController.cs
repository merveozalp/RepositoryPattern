using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Business.Abstract;
using RepositoryPattern.Domain;

namespace RepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentsController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var result = studentService.GetList();

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetById(int Id)
        {
            var result = studentService.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            studentService.Add(student);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Student student)
        {
            studentService.Update(student);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(Student student)
        {
            studentService.Delete(student);
            return Ok();
        }
    }
}


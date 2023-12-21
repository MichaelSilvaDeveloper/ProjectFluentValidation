using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectFluentValidation.API.Models;

namespace ProjectFluentValidation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(AddStudentInputModel addStudentInputModel)
        {
            return CreatedAtAction(nameof(Get), new { id = 1 }, addStudentInputModel);
        }
    }
}
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        private readonly IInstructorService _instructorService;

        public InstructorController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        [HttpPost("add")]
        public IActionResult Add(Instructor instructor)
        {
            _instructorService.Add(instructor);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult Update(Instructor instructor)
        {
            _instructorService.Update(instructor);
            return Ok();
        }
        [HttpPost("delete")]
        public IActionResult Delete(Instructor instructor)
        {
            _instructorService.Delete(instructor);
            return Ok();
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _instructorService.GetById(id);
            return Ok(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _instructorService.GetAll();
            return Ok(result);
        }
    }
}

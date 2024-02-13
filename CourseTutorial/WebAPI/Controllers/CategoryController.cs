using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost("add")]
        public IActionResult Add(Category category)
        {
            _categoryService.Add(category);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult Update(Category category)
        {
            _categoryService.Update(category);
            return Ok();
        }
        [HttpPost("delete")]
        public IActionResult Delete(Category category)
        {
            _categoryService.Delete(category);
            return Ok();
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result=_categoryService.GetById(id);
            return Ok(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            return Ok(result);
        }
    }
}

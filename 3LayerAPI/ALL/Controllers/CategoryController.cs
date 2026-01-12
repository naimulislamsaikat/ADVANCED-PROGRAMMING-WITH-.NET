using BLL.DTOs;
using BLL.Services;
using DAL.EF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ALL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        CategoryService service;
        public CategoryController(CategoryService service)
        {
            this.service = service;
        }
        [HttpGet("all")]
        public IActionResult All()
        {
            var categories = service.Get();
            return Ok(categories);
        }
        public IActionResult Get(int id)
        {
            var category = service.Get(id);
            return Ok(category);
        }
        [HttpPost("create")]
        public IActionResult Create(CategoryDTO category)
        {
            var createdCategory = service.Create(category);
            if (createdCategory == true)
            {
                return Ok("Category created successfully.");
            }
            else
            {
                return BadRequest("Category creation failed.");

            }
            //return Ok(createdCategory);
        }

        [HttpPost("update")]
        public IActionResult Update(CategoryDTO category)
        {
            var updatedCategory = service.Update(category);
            if (updatedCategory == true)
            {
                return Ok("Category updated successfully.");
            }
            else
            {
                return BadRequest("Category update failed.");
            }
            //return Ok(updatedCategory);
        }

        [HttpPost("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var deletedCategory = service.Delete(id);
            if (deletedCategory == true)
            {
                return Ok("Category deleted successfully.");
            }
            else
            {
                return BadRequest("Category deletion failed.");
            }
            //return Ok(deletedCategory);
        }
    }
}

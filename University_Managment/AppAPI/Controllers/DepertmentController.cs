using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepertmentController : ControllerBase
    {
        DepertmentService service;
        public DepertmentController(DepertmentService service)
        {
            this.service = service;
        }

        [HttpGet("all")]
        public IActionResult All()
        {
            var data = service.All();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = service.Get(id);
            return Ok(data);
        }

        [HttpPost("create")]
        public IActionResult Create(DepertmentDTO dp)
        {
            var data = service.Create(dp);
            return Ok(data);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var data = service.Delete(id);
            return Ok(data);
        }
        [HttpPut("update")]
        public IActionResult Update(DepertmentDTO dp)
        {
            var data = service.Update(dp);
            return Ok(data);
        }
    }
}

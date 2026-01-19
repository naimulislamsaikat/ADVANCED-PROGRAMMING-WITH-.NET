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
        public IActionResult Create(DepertmentDTO d)
        {

            var rs = service.Create(d);
            return Ok(rs);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var rs = service.Delete(id);
            return Ok(rs);
        }
        [HttpPut("update")]
        public IActionResult Update(DepertmentDTO d)
        {
            var rs = service.Update(d);
            return Ok(rs);
        }
    }
}

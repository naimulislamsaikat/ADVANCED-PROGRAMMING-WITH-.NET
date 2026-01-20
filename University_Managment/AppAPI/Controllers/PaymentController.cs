using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        PaymentService service;
        public PaymentController(PaymentService service)
        {
            this.service = service;
        }

        [HttpGet("all")]
        public IActionResult All()
        {
            var data = service.All();
            return Ok(data);
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] PaymentDTO dp)
        {
            var data = service.Create(dp);
            return Ok(data);
        }

        [HttpPut("update")]
        public IActionResult Update(PaymentDTO dp)
        {
            var data = service.Update(dp);
            return Ok(data);
        }
        [HttpGet("check/{id}")]
        public IActionResult GetById(int id)
        {
            var data = service.Get(id);
            return Ok(data);

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using ProductClientHub.Communication.Requests;

namespace ProductClientHub.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RequestClientJson request)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id}", Name = "Id of Client")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete()
        {
            return Ok();
        }
    }
}

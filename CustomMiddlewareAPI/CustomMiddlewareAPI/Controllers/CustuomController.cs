using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomMiddlewareAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustuomController : ControllerBase
    {
        [HttpGet]
        public IActionResult Test()
        {
            return Ok("Middleware works");
        }
    }
}

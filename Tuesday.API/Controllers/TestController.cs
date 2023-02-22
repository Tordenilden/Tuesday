using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tuesday.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("Tuesday")]
        public string Tuesday() { return "this is tuesday"; }
    }
}

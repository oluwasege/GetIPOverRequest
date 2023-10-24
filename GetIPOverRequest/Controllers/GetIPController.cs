using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GetIPOverRequest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GetIPController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(GetIpAddress);
        }

    }
}

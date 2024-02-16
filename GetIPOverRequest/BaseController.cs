using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace GetIPOverRequest
{
    public class BaseController : ControllerBase
    {
        public string IpAddress => Request.Headers.TryGetValue("X-Forwarded-For", out StringValues value) ? value : HttpContext.Connection.RemoteIpAddress?.MapToIPv4().ToString() ?? null;

    }
}

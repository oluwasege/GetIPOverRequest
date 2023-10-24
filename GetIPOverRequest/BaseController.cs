using Microsoft.AspNetCore.Mvc;

namespace GetIPOverRequest
{
    public class BaseController : ControllerBase
    {
        public string? IpAddress => Request.Headers.ContainsKey("X-Forwarded-For")
                    ? Request.Headers["X-Forwarded-For"]
                    : HttpContext.Connection.RemoteIpAddress?.MapToIPv4().ToString() ?? null;
    }
}

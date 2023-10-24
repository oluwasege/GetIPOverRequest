using Microsoft.AspNetCore.Mvc;

namespace GetIPOverRequest
{
    public class BaseController : ControllerBase
    {
        protected string? GetIpAddress
        {
            get
            {
                return Request.Headers.ContainsKey("X-Forwarded-For")
            ? Request.Headers["X-Forwarded-For"]
            : HttpContext.Connection.RemoteIpAddress?.MapToIPv4().ToString() ?? "N/A";
            }
        }
    }
}

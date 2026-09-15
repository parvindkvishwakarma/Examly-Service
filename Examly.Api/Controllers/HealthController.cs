using Microsoft.AspNetCore.Mvc;

namespace Examly.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Examly API is running");
    }
}
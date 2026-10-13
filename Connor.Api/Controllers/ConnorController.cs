using Microsoft.AspNetCore.Mvc;

namespace Connor.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ConnorController : ControllerBase
{
    [HttpGet("[action]")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Exception))]
    public async Task<IActionResult> Get()
    {
        await Task.Delay(0);
        return StatusCode(200, "Ok");
    }
}
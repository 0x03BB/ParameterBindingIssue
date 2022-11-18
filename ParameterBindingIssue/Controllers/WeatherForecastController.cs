using Microsoft.AspNetCore.Mvc;

namespace ParameterBindingIssue.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpPost("IEnumerable")]
    public IActionResult PostIEnumerable(IEnumerable<WeatherForecast> forecasts) => forecasts.Any() ? Ok() : BadRequest();

    [HttpPost("WithAttribute")]
    public IActionResult PostWithAttribute([FromBody] IEnumerable<WeatherForecast> forecasts) => forecasts.Any() ? Ok() : BadRequest();

    [HttpPost("List")]
    public IActionResult PostList(List<WeatherForecast> forecasts) => forecasts.Any() ? Ok() : BadRequest();
}

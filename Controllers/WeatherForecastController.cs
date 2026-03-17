namespace nativegit_postman.Controllers;

using Microsoft.AspNetCore.Mvc;
using nativegit_postman.Models;
using nativegit_postman.Services;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherService _weatherService;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(IWeatherService weatherService, ILogger<WeatherForecastController> logger)
    {
        _weatherService = weatherService;
        _logger = logger;
    }

    /// <summary>
    /// Get weather forecast for the next 5 days
    /// </summary>
    /// <returns>List of weather forecasts</returns>
    [HttpGet(Name = "GetWeatherForecast")]
    public ActionResult<IEnumerable<WeatherForecast>> Get()
    {
        _logger.LogInformation("Getting weather forecast");
        var forecast = _weatherService.GetForecast();
        return Ok(forecast);
    }
}

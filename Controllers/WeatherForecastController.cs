using GlobalExceptionHandling_CoreMVC_API.Middleware1;
using Microsoft.AspNetCore.Mvc;

namespace GlobalExceptionHandling_CoreMVC_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //Forcefully throwing an exception using try and catch in (if (list != null))
        //[HttpGet(Name = "GetWeatherForecast")]
        //public IActionResult Get()
        //{
        //    try
        //    {
        //        IEnumerable<WeatherForecast> list = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //        {
        //            Date = DateTime.Now.AddDays(index),
        //            TemperatureC = Random.Shared.Next(-20, 55),
        //            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //        })
        //         .ToArray();
        //        if (list != null)
        //            throw new ApplicationException();
        //        return Ok(list);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        return BadRequest(ex.Message);
        //    }
        //}

        //GLOBAL EXCEPTION HANDLER - Middleware
        //[HttpGet(Name = "GetWeatherForecast")]
        //public IActionResult Get()
        //{
        //    IEnumerable<WeatherForecast> list = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    }).ToArray();

        //    if (list != null)
        //        throw new Exception();

        //    return Ok(list);
        //}

        //GLOBAL EXCEPTION HANDLER - Middleware1
        [HttpGet]
        public IActionResult Get()
        {
            throw new SomeException("An error occurred...");
        }
    }
}
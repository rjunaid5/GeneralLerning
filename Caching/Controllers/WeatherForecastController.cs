using Microsoft.AspNetCore.Mvc;

namespace Caching.Controllers
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

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("cachedData")]
        public ActionResult<string> GetCachedData([FromHeader(Name = "X-Cached-Data")] string cachedData)
        {
            if (!string.IsNullOrEmpty(cachedData))
            {
                return Ok($"Data from cache: {cachedData}");
            }
            else
            {
                return NotFound("Data not found in cache.");
            }
        }
    }
}
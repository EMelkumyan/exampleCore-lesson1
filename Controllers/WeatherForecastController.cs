using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //объявим список
        private static List<WeatherForecast> WeatherForecasts { get; set; }
        //ініціалізуємо його в статік конструкторе
        static WeatherForecastController()
        {
            WeatherForecasts = new List<WeatherForecast>();
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //опишемо post запит
        [HttpPost]
        public void Create(WeatherForecast weatherForecast)
        {
            WeatherForecasts.Add(weatherForecast);
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            /*
             //код за замовчанням
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
            */
            return WeatherForecasts;
        }
    }
}

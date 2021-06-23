using cdays21.lib.Models;
using cdays21.lib.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace cdays21.maui.Services
{
    public class DataService : IDataService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public string AppTitle => "cdays21.maui";

        public Task<WeatherForecast[]> GetForecastAsync()
        {
            var startDate = DateTime.Now;
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}

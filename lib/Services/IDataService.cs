using cdays21.lib.Models;
using System.Threading.Tasks;

namespace cdays21.lib.Services
{
    public interface IDataService
    {
        Task<WeatherForecast[]> GetForecastAsync();

        public string AppTitle { get; }
    }
}

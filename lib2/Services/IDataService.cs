using cdays21.lib2.Models;
using System.Threading.Tasks;

namespace cdays21.lib2.Services
{
    public interface IDataService
    {
        Task<WeatherForecast[]> GetForecastAsync();

        public string AppTitle { get; }
    }
}

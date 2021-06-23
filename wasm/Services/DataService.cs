using cdays21.lib.Models;
using cdays21.lib.Services;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace cdays21.wasm.Services
{
    public class DataService : IDataService
    {
        private readonly HttpClient _httpClient;

        public DataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public string AppTitle => "cdays21.wasm";

        public Task<WeatherForecast[]> GetForecastAsync()
        {
            return _httpClient.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }
    }
}

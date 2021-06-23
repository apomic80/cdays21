using cdays21.lib.Models;
using cdays21.lib.Services;
using Microsoft.Win32;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace cdays21.wpf.Services
{
    public class DataService : IDataService
    {
        public string AppTitle => "cdays21.wpf";

        public Task<WeatherForecast[]> GetForecastAsync()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            bool? result = openFileDialog.ShowDialog();
            if (result == true)
            {
                string json = File.ReadAllText(openFileDialog.FileName); ;
                return Task.FromResult(JsonSerializer.Deserialize<WeatherForecast[]>(json));
            }
            else return Task.FromResult(new WeatherForecast[0]);
        }
    }
}

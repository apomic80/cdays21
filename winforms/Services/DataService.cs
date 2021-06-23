using cdays21.lib.Models;
using cdays21.lib.Services;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cdays21.winforms.Services
{
    public class DataService : IDataService
    {
        public string AppTitle => "cdays21.winforms";

        public Task<WeatherForecast[]> GetForecastAsync()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(openFileDialog.FileName); ;
                return Task.FromResult(JsonSerializer.Deserialize<WeatherForecast[]>(json));
            }
            else return Task.FromResult(new WeatherForecast[0]);
        }
    }
}

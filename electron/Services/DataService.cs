using cdays21.lib2.Models;
using cdays21.lib2.Services;
using ElectronNET.API;
using ElectronNET.API.Entities;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace cdays21.electron.Services
{
    public class DataService : IDataService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public string AppTitle => "cdays21.electron";

        public async Task<WeatherForecast[]> GetForecastAsync()
        {
            var mainWindow = Electron.WindowManager.BrowserWindows.First();
            var options = new OpenDialogOptions
            {
                Properties = new OpenDialogProperty[] 
                {
                        OpenDialogProperty.openFile
                }
            };

            string[] files = await Electron.Dialog.ShowOpenDialogAsync(mainWindow, options);

            string json = File.ReadAllText(files[0]); ;
            return System.Text.Json.JsonSerializer.Deserialize<WeatherForecast[]>(json);
        }
    }
}

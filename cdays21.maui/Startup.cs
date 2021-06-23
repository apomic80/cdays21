using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Hosting;
using cdays21.lib.Services;
using cdays21.maui.Services;

namespace cdays21.maui
{
	public class Startup : IStartup
	{
		public void Configure(IAppHostBuilder appBuilder)
		{
			appBuilder
				.RegisterBlazorMauiWebView(typeof(Startup).Assembly)
				.UseMicrosoftExtensionsServiceProviderFactory()
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				})
				.ConfigureServices(services =>
				{
					services.AddBlazorWebView();
					services.AddScoped<IDataService, DataService>();
				});
		}
	}
}
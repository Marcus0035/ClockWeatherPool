using ClockWeatherPool.Services.WeatherService.Models;
using System.Text.Json;

namespace ClockWeatherPool.Services.WeatherService
{
    public class WeatherService
    {
        private readonly HttpClient client = new HttpClient();

        private readonly string apiPath = @"https://api.weatherapi.com/v1/current.json?key=6deb327ec7934f72a2b134357251202&q=slany&aqi=no";

        public async Task<WeatherData?> GetWeatherData()
        {
            try
            {
                string response = await client.GetStringAsync(apiPath);
                return JsonSerializer.Deserialize<WeatherData>(response, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Chyba při získávání počasí: {ex.Message}");
                return null;
            }
        }
    }

}

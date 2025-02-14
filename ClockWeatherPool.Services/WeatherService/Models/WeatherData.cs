using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClockWeatherPool.Services.WeatherService.Models
{
    public class WeatherData
    {
        public Location Location { get; set; }
        public CurrentWeather Current { get; set; }
    }
}

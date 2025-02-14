using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockWeatherPool.Services.WeatherService.Models
{
    public class CurrentWeather
    {
        public double TempC { get; set; }
        public WeatherCondition Condition { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockWeatherPool.Services.WeatherService.Models
{
    public class AirQuality
    {
        public double CO { get; set; }
        public double NO2 { get; set; }
        public double O3 { get; set; }
        public double SO2 { get; set; }
        public double PM2_5 { get; set; }
        public double PM10 { get; set; }
        public int UsEpaIndex { get; set; }
        public int GbDefraIndex { get; set; }
    }
}

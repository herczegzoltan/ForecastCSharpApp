using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp.Models
{
    public class DailyDataModel
    {
        public string time { get; set; }
        public string summary { get; set; }
        public string icon { get; set; }
        public string sunriseTime { get; set; }
        public string sunsetTime { get; set; }
        public string moonPhase { get; set; }
        public string precipstringensity { get; set; }
        public string precipstringensityMax { get; set; }
        public string precipstringensityMaxTime { get; set; }
        public string precipProbability { get; set; }
        public string precipType { get; set; }
        public string temperatureHigh { get; set; }
        public string temperatureHighTime { get; set; }
        public string temperatureLow { get; set; }
        public string temperatureLowTime { get; set; }
        public string apparentTemperatureHigh { get; set; }
        public string apparentTemperatureHighTime { get; set; }
        public string apparentTemperatureLow { get; set; }
        public string apparentTemperatureLowTime { get; set; }
        public string dewPostring { get; set; }
        public string humidity { get; set; }
        public string pressure { get; set; }
        public string windSpeed { get; set; }
        public string windGust { get; set; }
        public string windGustTime { get; set; }
        public string windBearing { get; set; }
        public string cloudCover { get; set; }
        public string uvIndex { get; set; }
        public string uvIndexTime { get; set; }
        public string visibility { get; set; }
        public string ozone { get; set; }
        public string temperatureMin { get; set; }
        public string temperatureMstringime { get; set; }
        public string temperatureMax { get; set; }
        public string temperatureMaxTime { get; set; }
        public string apparentTemperatureMin { get; set; }
        public string apparentTemperatureMstringime { get; set; }
        public string apparentTemperatureMax { get; set; }
        public string apparentTemperatureMaxTime { get; set; }
    }
}

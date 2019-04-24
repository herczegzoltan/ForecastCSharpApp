using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp.Models
{
    public class Currently
    {
        public string time { get; set; }
        public string summary { get; set; }
        public string icon { get; set; }
        public string precipstringensity { get; set; }
        public string precipProbability { get; set; }
        public string precipType { get; set; }
        public string temperature { get; set; }
        public string apparentTemperature { get; set; }
        public string dewPostring { get; set; }
        public string humidity { get; set; }
        public string pressure { get; set; }
        public string windSpeed { get; set; }
        public string windGust { get; set; }
        public string windBearing { get; set; }
        public string cloudCover { get; set; }
        public string uvIndex { get; set; }
        public string visibility { get; set; }
        public string ozone { get; set; }
    }
}

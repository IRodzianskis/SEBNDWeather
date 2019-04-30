using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEBNDWeather
{
    public class WeatherData
    {
        public string NameOfCity { get; set; }
        public double Temperature { get; set; }
        public string DateOfRecord { get; set; }
        public bool WasPrecipitation { get; set; }
        public double WindSpeed { get; set; }
        public string WindDirection { get; set; }
    }
}

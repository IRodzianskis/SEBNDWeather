using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEBNDWeather
{
    class WeatherData
    {
        public string NameOfCity { get; set; }
        public float Temerature { get; set; }
        public DateTime DateOfRecord { get; set; }
        public bool WasPrecipitation { get; set; }
        public float WindSpeed { get; set; }
        public List<string> WindDirection { get; set; }
    }
}

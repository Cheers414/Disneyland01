using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disney1
{

    public class WeatherData
    {
        public Weatherlist[] WeatherList { get; set; }
    }

    public class Weatherlist
    {
        public string Date { get; set; }
        public string TempMax { get; set; }
        public string TempMin { get; set; }
        public string Humidity { get; set; }
        public Timeweather[] TimeWeather { get; set; }
    }

    public class Timeweather
    {
        public string Time { get; set; }
        public string Temp { get; set; }
        public string POP { get; set; }
    }

}

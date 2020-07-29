using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.InteropServices;

namespace Disney1.DisneylandResort
{
    public partial class Weather : UserControl
    {
        public Weather()
        {
            InitializeComponent();
        }

        public void DataRefresh()
        {
            rbToday.Checked = true;
        }

        private void rbToday_CheckedChanged(object sender, EventArgs e)
        {
            string jsonText = File.ReadAllText("WeatherData.json");
            var weatherData = JsonConvert.DeserializeObject<WeatherData>(jsonText);
            Weatherlist weather;

            if (rbToday.Checked)
            {
                weather = weatherData.WeatherList.FirstOrDefault(x => Convert.ToDateTime(x.Date) == DateTime.Today);
            }
            else
            {
                weather = weatherData.WeatherList.FirstOrDefault(x => Convert.ToDateTime(x.Date) == DateTime.Today.AddDays(1));
            }

            if(weather == null)
            {
                return;
            }

            lblWeather.Text =
                $"Date: {weather.Date}\n" +
                $"Time: {DateTime.Now.ToString("hh:mm")}\n" +
                $"Weather: {weather.Weather}\n" +
                $"Maximum temperature: {weather.TempMax}\n" +
                $"Minimum temperature: {weather.TempMin}\n" +
                $"Humidity: {weather.Humidity}";

            dgv.DataSource = weather.TimeWeather.Select(x => new
            {
                x.Time,
                x.Temp,
                x.POP
            }).ToList();

        }
    }
}

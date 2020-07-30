using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Disney1.Manage.Manager
{
    public partial class SetWeather : UserControl
    {
        public SetWeather()
        {
            InitializeComponent();
        }

        WeatherData weatherData;
        Timeweather[] timeWeather;
        int mode = 2;

        public void DataRefresh()
        {
            string jsonText = File.ReadAllText("WeatherData.json");
            weatherData = JsonConvert.DeserializeObject<WeatherData>(jsonText);

            dtp.Value = DateTime.Today;
        }

        private void dgvReset()
        {
            dgv.DataSource = timeWeather.ToList();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            var weather = weatherData.WeatherList.ToList().SingleOrDefault(x => Convert.ToDateTime(x.Date) == dtp.Value);
            if (weather == null)
            {
                mode = 2;
                txtHumidity.Text = "";
                txtMax.Text = "";
                txtMin.Text = "";
                txtWeather.Text = "";
                txtTemp.Text = "";
                txtTime.Text = "";
                txtPOP.Text = "";
                timeWeather = null;
                dgv.DataSource = null;
            }
            else
            {
                mode = 0;
                txtHumidity.Text = weather.Humidity;
                txtMax.Text = weather.TempMax;
                txtMin.Text = weather.TempMin;
                txtWeather.Text = weather.Weather;
                timeWeather = weather.TimeWeather;
                dgvReset();
            }
        }

        private void SaveData()
        {
            try
            {
                var weather = weatherData.WeatherList.ToList();
                if (mode == 1)
                {
                    List<Timeweather> lstWeather = timeWeather.ToList();
                    lstWeather.Add(new Timeweather
                    {
                        Time = txtTime.Text,
                        Temp = txtTemp.Text,
                        POP = txtPOP.Text
                    });
                    timeWeather = lstWeather.ToArray();
                    weatherData.WeatherList.Single(x => Convert.ToDateTime(x.Date) == dtp.Value).TimeWeather = timeWeather;
                }
                else if (mode == 2)
                {
                    List<Timeweather> lstWeather = new List<Timeweather>();
                    lstWeather.Add(new Timeweather
                    {
                        Time = txtTime.Text,
                        Temp = txtTemp.Text,
                        POP = txtPOP.Text
                    });
                    timeWeather = lstWeather.ToArray();

                    weather.Add(new Weatherlist
                    {
                        Date = dtp.Value.ToString("yyyy/MM/dd"),
                        Humidity = txtHumidity.Text,
                        TempMax = txtMax.Text,
                        TempMin = txtMin.Text,
                        Weather = txtWeather.Text,
                        TimeWeather = timeWeather
                    });
                    weatherData.WeatherList = weather.ToArray();
                }
                else
                {
                    var updateWeather = weather.SingleOrDefault(x => Convert.ToDateTime(x.Date) == dtp.Value);
                    updateWeather.Humidity = txtHumidity.Text;
                    updateWeather.TempMax = txtMax.Text;
                    updateWeather.TempMin = txtMin.Text;
                    updateWeather.Weather = txtWeather.Text;
                    timeWeather[dgv.CurrentCell.RowIndex].POP = txtPOP.Text;
                    timeWeather[dgv.CurrentCell.RowIndex].Time = txtTime.Text;
                    timeWeather[dgv.CurrentCell.RowIndex].Temp = txtTemp.Text;
                    updateWeather.TimeWeather = timeWeather;
                }

                File.WriteAllText("WeatherData.json", JsonConvert.SerializeObject(weatherData));
                dgvReset();
                MessageBox.Show("Save successfully.", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Data Error.", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(mode == 2)
            {
                return;
            }
            mode = 1;
            txtTime.Text = "";
            txtTemp.Text = "";
            txtPOP.Text = "";
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count != 1)
            {
                return;
            }
            txtTime.Text = timeWeather[dgv.CurrentCell.RowIndex].Time;
            txtTemp.Text = timeWeather[dgv.CurrentCell.RowIndex].Temp;
            txtPOP.Text = timeWeather[dgv.CurrentCell.RowIndex].POP;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var newTimeWeather = timeWeather.ToList();
            newTimeWeather.RemoveAt(dgv.CurrentCell.RowIndex);
            timeWeather = newTimeWeather.ToArray();
            dgvReset();
        }
    }
}

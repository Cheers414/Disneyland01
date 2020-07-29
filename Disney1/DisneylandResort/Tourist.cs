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

namespace Disney1.DisneylandResort
{
    public partial class Tourist : UserControl
    {
        public Tourist()
        {
            InitializeComponent();
        }

        public void DataRefresh()
        {
            string jsonText = File.ReadAllText("TouristStatistics.json");
            TouristData touristData = JsonConvert.DeserializeObject<TouristData>(jsonText);
            lblTouristStatistics.Text =
                $"Total Tourist: {touristData.Total}\n" +
                $"Current Tourist: {touristData.Current}\n";
            dgv.DataSource = touristData.ThemeParkTourist.OrderByDescending(x => Convert.ToInt32(x.NumberOfTourist)).ToList();
        }
    }
}

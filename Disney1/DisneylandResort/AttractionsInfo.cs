using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Disney1.DisneylandResort
{
    public partial class AttractionsInfo : UserControl, IKumotoyureiUserControl
    {
        public AttractionsInfo()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();
            cboAttractions.DataSource = db.Attractions;
            cboAttractions.DisplayMember = "AttractionsName";
        }

        private void cboThemePark_SelectedIndexChanged(object sender, EventArgs e)
        {
            var attraction = (Attractions)cboAttractions.SelectedItem;
            int num = db.QueueRecord.ToList().Where(x => x.AttractionsNo == attraction.AttractionsNo && x.isQueue == true).Count();
            lblAttractionsInfo.Text =
                $"Features: {attraction.Features}\n" +
                $"Suitable for: {attraction.SuitableFor}\n" +
                $"{GetQueueTime(attraction, num).ToString()} minute wait";
            string path = Application.StartupPath + $@"\Images\Attractions\{attraction.Photo}";
            if (File.Exists(path))
            {
                picAttractions.Image = Image.FromFile(path);
            }
            else
            {
                picAttractions.Image = null;
            }
        }

        private double GetQueueTime(Attractions attr, int num)
        {
            return Math.Round((Math.Ceiling(num / (double)attr.BatchConsumption) * (double)attr.TimeSpenSeconds) / 60, 0);
        }

        private void AttractionsInfo_Load(object sender, EventArgs e)
        {

        }
    }
}

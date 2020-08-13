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

namespace Disney1.DisneylandResort
{
    public partial class TrafficInfo : UserControl, IKumotoyureiUserControl
    {
        public TrafficInfo()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();
            cboTraffic.DataSource = db.TrafficMethod;
            cboTraffic.DisplayMember = "Method";
        }

        private void cboTraffic_SelectedIndexChanged(object sender, EventArgs e)
        {
            var traffic = (TrafficMethod)cboTraffic.SelectedItem;
            lblTraffic.Text = traffic.TrafficContent;
            string path = Application.StartupPath + $@"\Images\Traffic\{traffic.Photo}";
            if (File.Exists(path))
            {
                picTraffic.Image = Image.FromFile(path);
            }
            else
            {
                picTraffic.Image = null;
            }
        }

        private void TrafficInfo_Load(object sender, EventArgs e)
        {
            DataRefresh();
        }
    }
}

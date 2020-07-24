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
    public partial class DisneylandResort : UserControl
    {
        public DisneylandResort()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();
            cboThemePark.DataSource = db.ThemePark;
            cboThemePark.DisplayMember = "ThemeParkName";
        }

        private void cboThemePark_SelectedIndexChanged(object sender, EventArgs e)
        {
            var themePark = (ThemePark)cboThemePark.SelectedItem;
            lblThemeParkInfo.Text = themePark.Introduction;
            string path = Application.StartupPath + $@"\Images\ThemePark\{themePark.Photo}";
            if (File.Exists(path))
            {
                picThemePark.Image = Image.FromFile(Application.StartupPath + $@"\Images\ThemePark\{themePark.Photo}");
            }
            else
            {
                picThemePark.Image = null;
            }
        }

        private void DisneylandResort_Load(object sender, EventArgs e)
        {
            DataRefresh();
        }
    }
}

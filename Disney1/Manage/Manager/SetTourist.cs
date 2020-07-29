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
using Disney1.DisneylandResort;
using Newtonsoft.Json;

namespace Disney1.Manage.Manager
{
    public partial class SetTourist : UserControl
    {
        public SetTourist()
        {
            InitializeComponent();
        }

        TouristData touristData;

        public void DataRefresh()
        {
            string jsonText = File.ReadAllText("TouristStatistics.json");
            touristData = JsonConvert.DeserializeObject<TouristData>(jsonText);

            txtTotal.Text = touristData.Total;
            txtCurrent.Text = touristData.Current;

            cboThemePark.DataSource = touristData.ThemeParkTourist;
            cboThemePark.DisplayMember = "ThemePark";
        }

        private void cboThemePark_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtThemePark.Text = ((Themeparktourist)cboThemePark.SelectedItem).NumberOfTourist;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            touristData.Total = txtTotal.Text;
            touristData.Current = txtCurrent.Text;
            touristData.ThemeParkTourist.ElementAt(cboThemePark.SelectedIndex).NumberOfTourist = txtThemePark.Text;

            File.WriteAllText("TouristStatistics.json", JsonConvert.SerializeObject(touristData));
            MessageBox.Show("Save successfully.", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

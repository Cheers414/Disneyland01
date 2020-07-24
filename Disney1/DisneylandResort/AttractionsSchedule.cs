using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disney1.DisneylandResort
{
    public partial class AttractionsSchedule : UserControl
    {
        public AttractionsSchedule()
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

        private void cboAttractions_SelectedIndexChanged(object sender, EventArgs e)
        {
            var attraction = (Attractions)cboAttractions.SelectedItem;
            var business = db.BusinessSchedule.FirstOrDefault(x=>x.AttractionsNo == attraction.AttractionsNo);
            lblSchedule.Text = $"business hours: {business.StartTime} ~ {business.EndTime}";
        }

        private void AttractionsSchedule_Load(object sender, EventArgs e)
        {
            
        }
    }
}

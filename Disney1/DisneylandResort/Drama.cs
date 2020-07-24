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
    public partial class Drama : UserControl
    {
        public Drama()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();
            cboAttractions.DataSource = db.Attractions.ToList().Where(x=>x.isStageDrama).ToList();
            cboAttractions.DisplayMember = "AttractionsName";
        }

        private void cboAttractions_SelectedIndexChanged(object sender, EventArgs e)
        {
            var attraction = (Attractions)cboAttractions.SelectedItem;
            var lstDrama = db.DramaSchedule.ToList().Where(x => x.AttractionsNo == attraction.AttractionsNo && x.Date == DateTime.Now.Date).OrderBy(x => x.ShowTime);
            if (lstDrama.Count() == 0)
            {
                lblDrama.Text = "No Schedule";
            }
            else
            {
                lblDrama.Text =
                    $"Next Showtime: {lstDrama.FirstOrDefault().ShowTime}\n" +
                    $"All Showtime: {lstDrama.Aggregate("", (current, next) => current + ", " + next.ShowTime.ToString()).Trim(',').Trim(' ')}\n" +
                    $"Duration: {Math.Round(attraction.TimeSpenSeconds / 60d, 0)}";
            }
        }

        private void Drama_Load(object sender, EventArgs e)
        {
            DataRefresh();
        }
    }
}

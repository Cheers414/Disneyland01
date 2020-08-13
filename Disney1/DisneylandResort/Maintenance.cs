using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Disney1.DisneylandResort
{
    public partial class Maintenance : UserControl, IKumotoyureiUserControl
    {
        public Maintenance()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();
            lstMaintenance.DataSource = db.MaintenanceSchedule
                .ToList()
                .Where(x => DateTime.Now > x.StartDateTiime && DateTime.Now < x.EndDateTime)
                .Select(x => x.Attractions.AttractionsName)
                .ToList();
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            DataRefresh();
        }
    }
}

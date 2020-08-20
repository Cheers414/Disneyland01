using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using word = Microsoft.Office.Interop.Word;

namespace Disney1.Manage.Manager
{
    public partial class MaintenanceStatistics : UserControl
    {
        public MaintenanceStatistics()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();
            monthCalendar1.SelectionStart = DateTime.Today;
            monthCalendar1.SelectionEnd = DateTime.Today;
            monthCalendar1_DateChanged(null, null);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dgv.Rows.Clear();
            db.MaintenanceSchedule.ToList().Where(x=>x.StartDateTiime <= monthCalendar1.SelectionStart && x.EndDateTime >= monthCalendar1.SelectionEnd).ToList().ForEach(x =>
            {
                dgv.Rows.Add(new object[]
                {
                    x.Attractions.AttractionsName,
                    x.Note
                });
            });
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog svd = new SaveFileDialog();
            svd.FileName = "Maintenance Statistics Report";
            svd.Filter = "PDF Document|*.pdf";
            if (svd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            Global.ExportReport(dgv, svd.FileName);
        }
    }
}

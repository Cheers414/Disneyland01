using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;

namespace Disney1.Manage.Manager
{
    public partial class QueueTimeStatistics : UserControl
    {
        public QueueTimeStatistics()
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
            db.Attractions.ToList().ForEach(x =>
            {
                var lstQueue = db.QueueRecord.ToList().Where(q => q.AttractionsNo == x.AttractionsNo && q.QueueDatetime.Date >= monthCalendar1.SelectionStart && q.QueueDatetime.Date <= monthCalendar1.SelectionEnd).ToList();
                TimeSpan averageTime = new TimeSpan(0);
                if (lstQueue.Count != 0)
                {
                    averageTime = TimeSpan.FromTicks(Convert.ToInt64(lstQueue
                    .Select(q => q.QueueTime.Ticks)
                    .Average()));
                }

                dgv.Rows.Add(new object[]
                {
                    x.AttractionsName,
                    averageTime.ToString("mm") + "min"
                });
            });

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog svd = new SaveFileDialog();
            svd.FileName = "Queue Time Report";
            svd.Filter = "PDF Document|*.pdf";
            if (svd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            var wordApp = new word.Application();
            wordApp.Visible = false;
            var wordDoc = wordApp.Documents.Add();
            dgv.SelectAll();
            Clipboard.SetDataObject(dgv.GetClipboardContent());
            wordDoc.Range().Paste();
            wordDoc.Tables[1].set_Style("Grid Table 4 - Accent 1");
            wordDoc.Tables[1].AutoFitBehavior(word.WdAutoFitBehavior.wdAutoFitWindow);
            wordDoc.SaveAs2(svd.FileName, word.WdSaveFormat.wdFormatPDF);
            wordDoc.Close(false);
            wordApp.Quit(false);

            System.Diagnostics.Process.Start(svd.FileName);
        }
    }
}

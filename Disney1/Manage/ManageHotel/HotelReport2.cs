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
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using System.Diagnostics;
using Rectangle = System.Drawing.Rectangle;

namespace Disney1.Manage.ManageHotel
{
    public partial class HotelReport2 : UserControl
    {
        public HotelReport2()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();

            dtpStart.MaxDate = DateTime.Today;
            dtpStart.Value = DateTime.Today;
            dtpEnd.MaxDate = DateTime.Today;
            dtpEnd.Value = DateTime.Today;
            cboRange.SelectedIndex = 0;
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStart.Value > dtpEnd.Value)
            {
                dtpEnd.MinDate = dtpStart.Value;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string range = (string)cboRange.SelectedItem;
            var data = db.RoomOrderDetail.ToList().Where(x => x.StartDate > dtpStart.Value && x.StartDate < dtpEnd.Value).ToList();
            if (data.Count == 0)
            {
                MessageBox.Show("Have no data", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            {

            }
            if (range == "Day")
            {
                chart.DataSource = data
                .GroupBy(x => x.StartDate) //Group by day
                .Select(x => new
                {
                    Day = x.First().StartDate.ToString("yyyy/MM/dd"),
                    OrderRoom = x.Count()
                });
            }
            else if (range == "Week")
            {
                chart.DataSource = data
                .GroupBy(x => (int)((x.StartDate.DayOfYear - 1) / 7)) //Group by week
                .Select(x => new
                {
                    Week = "Week" + ((int)((x.First().StartDate.DayOfYear - 1) / 7) + 1).ToString(),
                    OrderRoom = x.Count()
                });
            }
            else if (range == "Month")
            {
                chart.DataSource = data
                .GroupBy(x => x.StartDate.Month) //Group by month
                .Select(x => new
                {
                    Month = x.Key.ToString(),
                    OrderRoom = x.Count()
                });
            }
            else if (range == "Season")
            {
                chart.DataSource = data
                .GroupBy(x => (int)((x.StartDate.Month - 1) / 3)) //Group by season
                .Select(x => new
                {
                    Season = "Season" + ((int)((x.First().StartDate.Month - 1) / 3) + 1).ToString(),
                    OrderRoom = x.Count()
                });
            }
            else if (range == "Year")
            {
                chart.DataSource = data
                .GroupBy(x => x.StartDate.Year) //Group by year
                .Select(x => new
                {
                    Year = x.Key.ToString(),
                    OrderRoom = x.Count()
                });
            }
            chart.Series[0].Name = "Room Order";
            chart.Series[0].XValueMember = $"{range}";
            chart.Series[0].YValueMembers = "OrderRoom";
            chart.DataBind();

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog svd = new SaveFileDialog();
            svd.Filter = "PDF Document|*.pdf";
            svd.FileName = "Room Order Report";
            if (svd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            Word.Application wapp = new Word.Application();
            wapp.Visible = false;
            Word.Document doc = wapp.Documents.Add();
            doc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));
            Clipboard.SetImage(bmp);
            doc.Range().Paste();
            doc.Range().ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            doc.SaveAs2(svd.FileName, Word.WdSaveFormat.wdFormatPDF);
            doc.Close(false);
            wapp.Quit(false);
            System.Diagnostics.Process.Start(svd.FileName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using BarcodeService;
using System.Drawing.Imaging;

namespace Disney1.Manage.ManageHotel
{
    public partial class GenerateTicket : UserControl
    {
        public GenerateTicket()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;
        Order order;
        List<Ticket> lstTicket;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();
            order = null;
            lstTicket = null;
            txtOrderId.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            order = db.Order.ToList().FirstOrDefault(x => x.OrderId == txtOrderId.Text);
            if (order == null)
            {
                MessageBox.Show("Order ID invalid", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lstTicket = db.Ticket.ToList().Where(x => x.OrderNo == order.OrderNo && x.EffectiveDate <= DateTime.Today && x.InvalidDate >= DateTime.Today).ToList();
            if (lstTicket.Count == 0)
            {
                MessageBox.Show("No valid ticket", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgv.DataSource = lstTicket.Select(x => new
            {
                x.TicketId,
                x.GuestName,
                x.TicketOffer.TicketName,
            }).ToList();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (lstTicket == null || lstTicket.Count == 0)
            {
                MessageBox.Show("Please search ticket order first", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string tempPath = Application.StartupPath + $@"\TicketTemplate\{order.OrderId}";
            Word.Application wapp = new Word.Application();
            wapp.Visible = false;
            if (Directory.Exists(tempPath))
            {
                var files = Directory.GetFiles(tempPath);
                for (int i = 0; i < files.Length; i++)
                {
                    File.Delete(files[i]);
                }
                Directory.Delete(tempPath);
            }
            Directory.CreateDirectory(tempPath);

            lstTicket.ForEach(x =>
            {
                Word.Document ticketDoc = wapp.Documents.Open(Application.StartupPath + @"\ticketTemp.dotm");
                ticketDoc.Bookmarks["date"].Range.Text = x.InvalidDate.ToString("yyyy-MMdd");
                ticketDoc.Bookmarks["dateType"].Range.Text = x.TicketOffer.TicketName.Contains("年票") ? "有效" : "入園";
                ticketDoc.Bookmarks["name"].Range.Text = x.GuestName;
                ticketDoc.Bookmarks["price"].Range.Text = x.TicketOffer.Price.ToString();
                ticketDoc.Bookmarks["ticketId"].Range.Text = x.TicketId;
                ticketDoc.Bookmarks["ticketType"].Range.Font.Color = x.TicketOffer.TicketName.Contains("年票") ? Word.WdColor.wdColorRed : Word.WdColor.wdColorBlue;
                ticketDoc.Bookmarks["ticketType"].Range.Text = x.TicketOffer.TicketName.Contains("年票") ? "年票 Annual Pass" : "一日票 One Day Pass";
                ticketDoc.Bookmarks["type"].Range.Text = x.TicketOffer.TicketName;

                Bitmap qrCode = QRCode.Generate(CreateCode(x), 100, 100);
                Clipboard.SetImage(qrCode);
                ticketDoc.Bookmarks["image"].Range.Paste();
                Clipboard.Clear();
                ticketDoc.SaveAs2(tempPath + $@"\{x.TicketId}.docx", Word.WdSaveFormat.wdFormatDocumentDefault);
                ticketDoc.Close(false);
            });

            var lstFile = Directory.GetFiles(tempPath);

            Word.Document mainDoc = new Word.Document();
            for (int i = 0; i < lstFile.Length; i++)
            {
                if (i % 5 == 0)
                {
                    mainDoc = wapp.Documents.Add();
                }

                Word.Paragraph paragraph = mainDoc.Paragraphs.Add();
                paragraph.Range.InsertFile(lstFile[i]);
                paragraph.Range.Delete();

                if (i == lstFile.Length - 1 || i % 5 == 4)
                {
                    mainDoc.SaveAs2(tempPath + $@"\{(int)(i/5) + 1}.pdf", Word.WdSaveFormat.wdFormatPDF);
                    mainDoc.Close(false);
                }
            }


            wapp.Quit(false);
        }

        private string CreateCode(Ticket ticket)
        {
            string code1 = "";
            string ticketName = ticket.TicketOffer.TicketName;
            if (ticketName.Contains("一日票"))
            {
                if (ticketName.Contains("平日"))
                {
                    code1 = "A";
                }
                if (ticketName.Contains("高峰"))
                {
                    code1 = "B";
                }
                if (ticketName.Contains("連假高峰"))
                {
                    code1 = "C";
                }
            }
            else
            {
                if (ticketName.Contains("發現銀卡"))
                {
                    code1 = "S";
                }
                if (ticketName.Contains("奇妙金卡"))
                {
                    code1 = "G";
                }
                if (ticketName.Contains("無限鑽石卡"))
                {
                    code1 = "D";
                }
            }

            string code2 = ticket.EffectiveDate.ToString("yyyyMMdd") + ":" + ticket.InvalidDate.ToString("yyyyMMdd");

            string code3 = "";
            if (ticketName.Contains("成人"))
            {
                code3 = "A";
            }
            if (ticketName.Contains("兒童"))
            {
                code3 = "C";
            }
            if (ticketName.Contains("老年"))
            {
                code3 = "E";
            }
            if (ticketName.Contains("身心障礙"))
            {
                code3 = "D";
            }

            string code4 = Guid.NewGuid().ToString().ToUpper().Replace("-", "");

            string code5 = ticket.GuestName;

            return $"{code1}:{code2}:{code3}:{code4}:{code5}";
        }
    }
}

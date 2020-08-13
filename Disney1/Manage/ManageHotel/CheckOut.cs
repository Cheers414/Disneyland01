using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Word = Microsoft.Office.Interop.Word;
using System.Security.Cryptography;

namespace Disney1.Manage.ManageHotel
{
    public partial class CheckOut : UserControl
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;
        RoomOrder order;
        List<PayItem> lstPay;
        PaymentMethod paymentMethod;
        int subtotal;
        double discount;
        int invoiceTotal;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();

            cboPayment.DataSource = db.PaymentMethod;
            cboPayment.DisplayMember = "Method";

            order = db.RoomOrder.ToList().SingleOrDefault(x => x.RoomOrderNo == Global.OrderRecord.RoomOrderNo);
            lstPay = new List<PayItem>();

            var detail = db.RoomOrderDetail.ToList().Where(x => x.RoomOrderNo == order.RoomOrderNo).ToList();
            detail.ForEach(x =>
            {
                lstPay.Add(new PayItem
                {
                    Description = x.Room.RoomSeries.SuitesName,
                    UnitCost = x.Room.RoomSeries.Price,
                    Qty = 1,
                    Amount = x.Room.RoomSeries.Price
                });
            });

            detail.ForEach(x =>
            {
                db.RoomServiceRecord.ToList().Where(y => y.RoomOrderDetailNo == x.RoomOrderDetailNo).ToList().ForEach(y =>
                {
                    lstPay.Add(new PayItem
                    {
                        Description = y.RoomService.ServiceName,
                        UnitCost = y.RoomService.Price,
                        Qty = y.Quantity,
                        Amount = y.RoomService.Price * y.Quantity
                    });
                });
            });

            lstPay = lstPay.GroupBy(x => new { x.Description, x.UnitCost })
                .Select(p => new PayItem
                {
                    Description = p.Key.Description,
                    UnitCost = p.Key.UnitCost,
                    Qty = p.Sum(q => q.Qty),
                    Amount = p.Sum(t => t.Qty) * p.Key.UnitCost
                }).ToList();

            dgv.DataSource = lstPay.Select(x => new
            {
                Description = x.Description,
                UnitCost = "$" + x.UnitCost,
                Qty = x.Qty,
                Amount = "$" + x.Amount
            }).ToList();

            subtotal = GetSubTotal();
            discount = GetDiscount();
            invoiceTotal = GetInvoiceTotal();
            lblSubtotal.Text = $"Subtotal: {subtotal}";
            lblDiscount.Text = $"Discount: {(discount == 1 ? "" : discount.ToString())}";
            lblPrice.Text = $"Total Price: {invoiceTotal}";
        }

        private int GetSubTotal()
        {
            int price = 0;
            db.RoomOrderDetail.ToList().Where(x => x.RoomOrderNo == order.RoomOrderNo).ToList().ForEach(x =>
            {
                price += x.Room.RoomSeries.Price;
                price += db.RoomServiceRecord.ToList().Where(y => y.RoomOrderDetailNo == x.RoomOrderDetailNo).Sum(y => y.RoomService.Price * y.Quantity);
            });
            return price;
        }

        private double GetDiscount()
        {
            return ((order.TicketId == null) ? 1 : 0.8) * ((order.CouponId == null) ? 1 : order.Coupon.Discount);
        }

        private int GetInvoiceTotal()
        {
            return (int)Math.Ceiling(subtotal * discount);
        }

        private string GetInoivce()
        {
            string invoice = "";
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            {
                invoice += rd.Next(0, 9);
            }
            return invoice;
        }

        private void PrintInvoice()
        {
            Hotel hotel = order.RoomOrderDetail.First().Room.RoomSeries.SuitesLevel.Hotel;
            string filename = Application.StartupPath + $@"\Invoice\{order.InvoiceNo}.pdf";

            var wapp = new Word.Application();
            wapp.Visible = false;
            var doc = wapp.Documents.Open(Application.StartupPath + @"\INVOICE.dotm");
            doc.Bookmarks["Billed"].Range.Text = order.Guest.Name;
            doc.Bookmarks["Date"].Range.Text = DateTime.Today.ToString("MM/dd/yyyy");
            doc.Bookmarks["Hotel"].Range.Text = hotel.HotelName;
            doc.Bookmarks["HotelDetail"].Range.Text = $"{hotel.Address}\n{hotel.PhoneNumber}";
            doc.Bookmarks["Invoice"].Range.Text = order.InvoiceNo;
            dgv.SelectAll();
            Clipboard.SetDataObject(dgv.GetClipboardContent());
            doc.Bookmarks["OrderDetail"].Range.Paste();
            doc.Bookmarks["Subtotal"].Range.Text = "$" + subtotal.ToString();
            doc.Bookmarks["Discount"].Range.Text = (discount == 1 ? "0.0" : discount.ToString());
            doc.Bookmarks["Total"].Range.Text = "$" + invoiceTotal.ToString();
            doc.Tables[1].set_Style("Plain Table 3");
            doc.Tables[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            doc.Tables[1].AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitWindow);
            doc.SaveAs2(filename, Word.WdSaveFormat.wdFormatPDF);
            doc.Close(false);
            wapp.Quit(false);
            System.Diagnostics.Process.Start(filename);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (paymentMethod.PaymentMethodNo == 2)
            {
                if (txtCredit.TextLength != 10)
                {
                    MessageBox.Show("Credit card format incorrect", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            order.PaymentMethodNo = paymentMethod.PaymentMethodNo;
            order.InvoiceNo = GetInoivce();

            var checkOut = db.CheckInRecord.ToList().SingleOrDefault(x => x.RoomOrderNo == order.RoomOrderNo);
            checkOut.CheckOutDateTime = DateTime.Now;
            order.RoomOrderDetail.ToList().ForEach(x =>
            {
                x.Room.RoomStatusNo = 4;
            });
            db.SubmitChanges();

            MessageBox.Show("Bill successfully", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnPay.Enabled = false;
            PrintInvoice();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public class PayItem
        {
            public string Description { get; set; }
            public int UnitCost { get; set; }
            public int Qty { get; set; }
            public int Amount { get; set; }
        }

        private void cboPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            paymentMethod = (PaymentMethod)cboPayment.SelectedItem;
            if (paymentMethod.PaymentMethodNo == 2)
            {
                txtCredit.Text = "";
                panelCreditCard.Visible = true;
            }
            else
            {
                panelCreditCard.Visible = false;
            }
        }
    }
}

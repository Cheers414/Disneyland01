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
using System.Data.Entity.ModelConfiguration.Configuration;
using System.IO;
using Word = Microsoft.Office.Interop.Word;

namespace Disney1.Manage.ManageHotel
{
    public partial class BookTicket : UserControl
    {
        public BookTicket()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;
        int step;
        List<GroupBox> lstGroup;
        List<Ticket> lstTicket;
        string dateType;
        RoomOrder roomOrder;
        Account account;
        Order order;

        public void DataRefresh(RoomOrder rOrder)
        {
            gbTicket.BringToFront();
            db = new DisneyDataDataContext();
            step = 0;
            lstGroup = new List<GroupBox>();
            lstTicket = new List<Ticket>();
            dateType = GetDateType();
            roomOrder = rOrder;
            account = null;
            order = null;

            lstGroup.Add(gbTicket);
            lstGroup.Add(gbTIcketInfo);
            lstGroup.Add(gbOrderDetail);
            lstGroup.Add(gbTicketDetail);
            lstGroup.Add(gbPayMethod);

            rbDay.Checked = true;
            dtpVisit.MinDate = DateTime.Today;
            dtpVisit.Value = DateTime.Today;
            cboAnnualType.SelectedIndex = 0;

            cboPayMethod.DataSource = db.PaymentMethod;
            cboPayMethod.DisplayMember = "Method";

            panelCredit.Visible = false;

            gbSignin.BringToFront();
        }

        private void dgvRefresh()
        {
            dgv.DataSource = lstTicket.Select(x => new
            {
                x.TicketId,
                db.TicketOffer.FirstOrDefault(s => s.TicketOfferNo == x.TicketOfferNo).TicketName,
                x.GuestName
            }).ToList();
        }

        private string GetDateType()
        {
            return db.BusinessSchedule.ToList().First(x => x.BusinessDate == dtpVisit.Value.Date).DateType;
        }

        private TicketOffer GetTicketType(string day, string type, string people)
        {
            string typeName = $"{day}-{type}-{people}";
            return db.TicketOffer.ToList().First(x => x.TicketName == typeName);
        }

        private TicketOffer GetTicketTypeById(int id)
        {
            return db.TicketOffer.Single(x => x.TicketOfferNo == id);
        }

        private List<string> GetOfferDetail(TicketOffer offer)
        {
            return offer.TicketName.Split('-').ToList();
        }

        private void AddTicket()
        {
            lstTicket.Clear();
            dateType = GetDateType();
            string annuelType = (string)cboAnnualType.SelectedItem;
            int lastId = Convert.ToInt32(db.Ticket.ToList().Last().TicketId); //這是三小
            int id = lastId + 1;

            if (rbAnnual.Checked)
            {
                for (int i = 0; i < nudStandard.Value; i++)
                {
                    TicketOffer ticketType = GetTicketType("年票", annuelType, "成人");
                    lstTicket.Add(new Ticket
                    {
                        TicketId = id.ToString().PadLeft(10, '0'),
                        TicketOfferNo = ticketType.TicketOfferNo,
                        EffectiveDate = dtpVisit.Value,
                        InvalidDate = dtpVisit.Value.AddDays(ticketType.ValidDay - 1),
                        GuestName = "",
                        Status = true
                    });
                    id += 1;
                }
                for (int i = 0; i < nudChild.Value; i++)
                {
                    TicketOffer ticketType = GetTicketType("年票", annuelType, "兒童");
                    lstTicket.Add(new Ticket
                    {
                        TicketId = id.ToString().PadLeft(10, '0'),
                        TicketOfferNo = ticketType.TicketOfferNo,
                        EffectiveDate = dtpVisit.Value,
                        InvalidDate = dtpVisit.Value.AddDays(ticketType.ValidDay - 1),
                        GuestName = "",
                        Status = true
                    });
                    id += 1;
                }
                for (int i = 0; i < nudSenior.Value; i++)
                {
                    TicketOffer ticketType = GetTicketType("年票", annuelType, "老年");
                    lstTicket.Add(new Ticket
                    {
                        TicketId = id.ToString().PadLeft(10, '0'),
                        TicketOfferNo = ticketType.TicketOfferNo,
                        EffectiveDate = dtpVisit.Value,
                        InvalidDate = dtpVisit.Value.AddDays(ticketType.ValidDay - 1),
                        GuestName = "",
                        Status = true
                    });
                    id += 1;
                }
                for (int i = 0; i < nudDisability.Value; i++)
                {
                    TicketOffer ticketType = GetTicketType("年票", annuelType, "身心障礙");
                    lstTicket.Add(new Ticket
                    {
                        TicketId = id.ToString().PadLeft(10, '0'),
                        TicketOfferNo = ticketType.TicketOfferNo,
                        EffectiveDate = dtpVisit.Value,
                        InvalidDate = dtpVisit.Value.AddDays(ticketType.ValidDay - 1),
                        GuestName = "",
                        Status = true
                    });
                    id += 1;
                }
            }
            else
            {
                for (int i = 0; i < nudStandard.Value; i++)
                {
                    TicketOffer ticketType = GetTicketType("一日票", dateType, "成人");
                    lstTicket.Add(new Ticket
                    {
                        TicketId = id.ToString().PadLeft(10, '0'),
                        TicketOfferNo = ticketType.TicketOfferNo,
                        EffectiveDate = dtpVisit.Value,
                        InvalidDate = dtpVisit.Value.AddDays(ticketType.ValidDay - 1),
                        GuestName = "",
                        Status = true
                    });
                    id += 1;
                }
                for (int i = 0; i < nudChild.Value; i++)
                {
                    TicketOffer ticketType = GetTicketType("一日票", dateType, "兒童");
                    lstTicket.Add(new Ticket
                    {
                        TicketId = id.ToString().PadLeft(10, '0'),
                        TicketOfferNo = ticketType.TicketOfferNo,
                        EffectiveDate = dtpVisit.Value,
                        InvalidDate = dtpVisit.Value.AddDays(ticketType.ValidDay - 1),
                        GuestName = "",
                        Status = true
                    });
                    id += 1;
                }
                for (int i = 0; i < nudSenior.Value; i++)
                {
                    TicketOffer ticketType = GetTicketType("一日票", dateType, "老年");
                    lstTicket.Add(new Ticket
                    {
                        TicketId = id.ToString().PadLeft(10, '0'),
                        TicketOfferNo = ticketType.TicketOfferNo,
                        EffectiveDate = dtpVisit.Value,
                        InvalidDate = dtpVisit.Value.AddDays(ticketType.ValidDay - 1),
                        GuestName = "",
                        Status = true
                    });
                    id += 1;
                }
                for (int i = 0; i < nudDisability.Value; i++)
                {
                    TicketOffer ticketType = GetTicketType("一日票", dateType, "身心障礙");
                    lstTicket.Add(new Ticket
                    {
                        TicketId = id.ToString().PadLeft(10, '0'),
                        TicketOfferNo = ticketType.TicketOfferNo,
                        EffectiveDate = dtpVisit.Value,
                        InvalidDate = dtpVisit.Value.AddDays(ticketType.ValidDay - 1),
                        GuestName = "",
                        Status = true
                    });
                    id += 1;
                }
            }
        }

        private bool CheckTicketInfo()
        {
            if (lstTicket.Any(x => x.GuestName == ""))
            {
                return false;
            }
            return true;
        }

        private int GetTotal()
        {
            return lstTicket.Sum(x => GetTicketTypeById(x.TicketOfferNo).Price);
        }

        private void ShowDetail()
        {
            dgvDetail.DataSource = lstTicket.GroupBy(x => x.TicketOfferNo).Select(x => new
            {
                Description = GetTicketTypeById(x.First().TicketOfferNo).TicketName,
                UnitCost = GetTicketTypeById(x.First().TicketOfferNo).Price,
                Qty = x.Count(),
                Amount = GetTicketTypeById(x.First().TicketOfferNo).Price * x.Count()
            }).ToList();
            lblTotal.Text = $"Total: ${GetTotal()}";
        }

        private void ShowTicketDetail()
        {
            dgvTicket.DataSource = lstTicket.Select(x => new
            {
                x.TicketId,
                x.GuestName,
                Category = GetOfferDetail(GetTicketTypeById(x.TicketOfferNo))[2],
                x.InvalidDate
            }).ToList();
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

        private string CreateOrderId()
        {
            string id = account.AccountId.Substring(account.AccountId.Length - 4);
            string type = rbAnnual.Checked ? "1Y" : "1D";
            string date = DateTime.Today.ToString("yyyyMMdd");
            string time = DateTime.Now.ToString("hhmmss");
            return $"{id}-{type}-{date}-{time}";
        }

        private void Book()
        {
            if (cboPayMethod.SelectedIndex == 1)
            {
                if (txtCredit.Text == "")
                {
                    MessageBox.Show("Please enter the credit card number", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            order = new Order
            {
                OrderId = CreateOrderId(),
                AccountId = account.AccountId,
                InvoiceId = GetInoivce(),
                PurchaseDateTime = DateTime.Now,
                Subtotal = GetTotal(),
                PaymentMethodNo = ((PaymentMethod)cboPayMethod.SelectedItem).PaymentMethodNo
            };
            db.Order.InsertOnSubmit(order);
            db.SubmitChanges();

            lstTicket.ForEach(x =>
            {
                x.OrderNo = order.OrderNo;
                db.Ticket.InsertOnSubmit(x);
                db.SubmitChanges();
            });

            db.RoomOrder.ToList().Single(x => x.RoomOrderNo == roomOrder.RoomOrderNo).Ticket = lstTicket.First();
            db.SubmitChanges();

            MessageBox.Show("Book successfully", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PrintInvoice()
        {
            string path = $@"C:\Tickets\{DateTime.Today.ToString("yyyyMMdd")}";

            Word.Application wapp = new Word.Application();
            wapp.Visible = false;
            Word.Document doc = wapp.Documents.Open(Application.StartupPath + @"\TicketINVOICE.dotm");
            doc.Bookmarks["Name"].Range.Text = lstTicket.First().GuestName;
            doc.Bookmarks["OrderDate"].Range.Text = DateTime.Today.ToString("MM/dd/yyyy");
            dgvDetail.SelectAll();
            Clipboard.SetDataObject(dgvDetail.GetClipboardContent());
            doc.Bookmarks["OrderDetail"].Range.Paste();
            doc.Bookmarks["OrderId"].Range.Text = order.OrderId;
            doc.Bookmarks["Subtotal"].Range.Text = "$" + order.Subtotal.ToString();
            doc.Tables[1].set_Style("Plain Table 3");
            doc.Tables[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            doc.Tables[1].AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitWindow);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            doc.SaveAs2(path + $@"\{order.OrderId}.pdf", Word.WdSaveFormat.wdFormatPDF);
            doc.Close(false);
            wapp.Quit(false);
            System.Diagnostics.Process.Start(path + $@"\{order.OrderId}.pdf");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            switch (step)
            {
                case 0:
                    if (account == null)
                    {
                        MessageBox.Show("Please sign in purchase account", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (nudChild.Value + nudDisability.Value + nudSenior.Value + nudStandard.Value > 10)
                    {
                        MessageBox.Show("You can only purchase up to 10 tickets", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    AddTicket();
                    dgvRefresh();
                    break;

                case 1:
                    if (CheckTicketInfo() == false)
                    {
                        MessageBox.Show("Any ticket have not input guest name", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    ShowDetail();
                    break;

                case 2:
                    ShowTicketDetail();
                    break;

                case 4:
                    Book();
                    PrintInvoice();
                    this.Visible = false;
                    return;
            }
            step += 1;
            lstGroup[step].BringToFront();
            if (step == lstGroup.Count - 1)
            {
                btnConfirm.Text = "Confirm";
            }
            else
            {
                btnConfirm.Text = "Next";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (step == 0)
            {
                this.Visible = false;
                return;
            }
            step -= 1;
            lstGroup[step].BringToFront();
            if (step == lstGroup.Count - 1)
            {
                btnConfirm.Text = "Confirm";
            }
            else
            {
                btnConfirm.Text = "Next";
            }
        }

        private void rbDay_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDay.Checked)
            {
                cboAnnualType.Enabled = false;
            }
            else
            {
                cboAnnualType.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lstTicket[dgv.SelectedRows[0].Index].GuestName = txtName.Text;
            dgvRefresh();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count != 1)
            {
                return;
            }
            txtName.Text = lstTicket[dgv.SelectedRows[0].Index].GuestName;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            account = db.Account.ToList().SingleOrDefault(x => x.AccountId == txtAccount.Text);
            if (account == null)
            {
                MessageBox.Show("Account is not exist", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Sign in successfully", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblAccountInfo.Text =
                $"Account: {account.AccountId}\n" +
                $"Name: {account.Name}";
            gbAccountInfo.BringToFront();
        }

        private void cboPayMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPayMethod.SelectedIndex == 1)
            {
                panelCredit.Visible = true;
            }
            else
            {
                panelCredit.Visible = false;
            }
        }
    }
}

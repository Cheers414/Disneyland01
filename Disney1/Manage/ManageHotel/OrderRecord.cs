using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace Disney1.Manage.ManageHotel
{
    public partial class OrderRecord : UserControl
    {
        public OrderRecord()
        {
            InitializeComponent();
            //checkOut1.CkeckOutSuccessfully += CheckOut1_CkeckOutSuccessfully;

            int k = this.DoSomething((x, y) => x + y);
            this.Ohhh = new Action(() =>
            {
                lblChildrenNum.Text = "1025";
            });
        }
        public int DoSomething(Func<int, int, int> func)
        {
            return func.Invoke(5, 8);
        }

        public Action Ohhh;

        private void CheckOut1_CkeckOutSuccessfully(object sender, EventArgs e)
        {
            DataRefresh();
            this.Ohhh?.Invoke();
        }

        DisneyDataDataContext db;
        List<Room> lstRooms;
        RoomOrder order;
        List<RoomOrderDetail> lstOrderDetail;

        public void DataRefresh()
        {
            checkOut1.Visible = false;
            bookTicket1.Visible = false;
            db = new DisneyDataDataContext();
            lstRoomId.DataSource = null;
            dgvOrder.DataSource = db.RoomOrder.ToList()
                .Where(x => x.PaymentMethodNo == null)
                .Select(x => new
                {
                    x.Guest.Name,
                    OrderTime = x.OrderDateTime.ToString("yyyy/MM/dd"),
                }).ToList();
            dgvOrder_SelectionChanged(null, null);
        }

        private void dgvOrder_SelectionChanged(object sender, EventArgs e)
        {
            order = null;
            if (dgvOrder.SelectedRows.Count != 1)
            {
                return;
            }
            int index = dgvOrder.SelectedRows[0].Index;

            order = db.RoomOrder.ToList().Where(x => x.PaymentMethodNo == null).ToList().ElementAt(index);
            lstOrderDetail = db.RoomOrderDetail.ToList().Where(x => x.RoomOrderNo == order.RoomOrderNo).ToList();
            lstRooms = lstOrderDetail.Select(x => x.Room).ToList();
            var checkRecord = db.CheckInRecord.ToList().SingleOrDefault(x => x.RoomOrderNo == order.RoomOrderNo);
            if (checkRecord != null)
            {
                btnCheckIn.Enabled = false;
                btnCheckOut.Enabled = true;
            }
            else
            {
                btnCheckIn.Enabled = true;
                btnCheckOut.Enabled = false;
            }

            txtTicket.Text = order.TicketId == null ? "" : order.TicketId;
            txtCoupon.Text = order.CouponId == null ? "" : order.CouponId;

            Global.OrderRecord = order;

            lstRoomId.DataSource = lstRooms;
            lstRoomId.DisplayMember = "RoomId";
        }

        private void lstRoomId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRoomId.SelectedIndex == -1)
            {
                return;
            }
            var detail = lstOrderDetail[lstRoomId.SelectedIndex];
            lblStayTime.Text = $"Stay Time: {detail.StartDate.ToString("yyyy/MM/dd")} - {detail.EndDate.ToString("yyyy/MM/dd")}";
            lblMainGuest.Text = $"Main Guest: {detail.MainGuest}";
            lblGuestNum.Text = $"Guest Number: {detail.GuestNum}";
            lblChildrenNum.Text = $"Children Number: {detail.ChildrenNum}";
            lblSpec.Text = $"Special Requirement:\n{detail.Note}";

            Global.OrderDetailRecord = detail;
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            if (order == null)
            {
                return;
            }
            new HotelService().ShowDialog();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (order == null)
            {
                return;
            }
            db.CheckInRecord.InsertOnSubmit(new CheckInRecord
            {
                RoomOrderNo = order.RoomOrderNo,
                CheckInDateTime = DateTime.Now,
                CheckOutDateTime = null,
                Note = null
            });

            db.RoomOrderDetail.ToList().Where(x => x.RoomOrderNo == order.RoomOrderNo).ToList()
            .ForEach(x =>
              {
                  var room = db.Room.ToList().Single(r => r.RoomNo == x.RoomNo);
                  room.RoomStatusNo = 3;
              });

            db.SubmitChanges();

            MessageBox.Show("Check in successfully", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvOrder_SelectionChanged(null, null);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (order == null)
            {
                return;
            }
            checkOut1.Visible = true;
            checkOut1.DataRefresh();
        }

        private void btnCheckTicket_Click(object sender, EventArgs e)
        {
            if (order == null)
            {
                return;
            }
            if (txtTicket.Text != "")
            {
                var t = db.Ticket.ToList().SingleOrDefault(x => x.TicketId == txtTicket.Text);
                if (t != null)
                {
                    order.Ticket = t;
                    MessageBox.Show("Ticket ID valid", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ticket ID invalid", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            db.SubmitChanges();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            if (order == null)
            {
                return;
            }
            if (order.TicketId == null)
            {
                return;
            }
            order.Ticket = null;
            db.SubmitChanges();
            MessageBox.Show("Delete successfully", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvOrder_SelectionChanged(null, null);
        }

        private void btnCheckCoupon_Click(object sender, EventArgs e)
        {
            if (order == null)
            {
                return;
            }
            if (txtCoupon.Text != "")
            {
                var c = db.Coupon.ToList().SingleOrDefault(x => x.CouponId == txtCoupon.Text && x.isEnable);
                if (c != null)
                {
                    order.Coupon = c;
                    c.isEnable = false;
                    MessageBox.Show("Coupon ID valid", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Coupon iD invalid", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            db.SubmitChanges();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            if (order == null)
            {
                return;
            }
            if (order.CouponId == null)
            {
                return;
            }
            db.Coupon.Single(x => x.CouponId == order.CouponId).isEnable = true;
            order.Coupon = null;
            db.SubmitChanges();
            MessageBox.Show("Delete successfully", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvOrder_SelectionChanged(null, null);
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            if (order == null)
            {
                return;
            }
            bookTicket1.Visible = true;
            bookTicket1.DataRefresh(order);
        }
    }
}

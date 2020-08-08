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
        }

        DisneyDataDataContext db;
        List<Room> lstRooms;
        RoomOrder order;
        List<RoomOrderDetail> lstOrderDetail;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();
            dgvOrder.DataSource = db.RoomOrder.ToList()
                .Where(x => x.PaymentMethodNo == null)
                .Select(x => new
                {
                    x.Guest.Name,
                    OrderTime = x.OrderDateTime.ToString("yyyy/MM/dd"),
                }).ToList();

        }

        private void dgvOrder_SelectionChanged(object sender, EventArgs e)
        {
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
            }
            else
            {
                btnCheckIn.Enabled = true;
            }

            Global.OrderRecord = order;

            lstRoomId.DataSource = lstRooms;
            lstRoomId.DisplayMember = "RoomId";
        }

        private void lstRoomId_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            new HotelService().ShowDialog();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
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
            btnCheckIn.Enabled = false;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;

namespace Disney1.Manage.ManageHotel
{
    public partial class BookingRoom : UserControl
    {
        public BookingRoom()
        {
            InitializeComponent();
        }

        List<RoomOrderDetail> orderDetail = new List<RoomOrderDetail>();
        RoomOrderDetail detail;
        bool breakfast = false;
        bool storage = false;

        public void DataRefresh()
        {
            orderDetail.Clear();
            Global.BookRooms.ToList().ForEach(x =>
            {
                orderDetail.Add(new RoomOrderDetail
                {
                    RoomNo = x.RoomNo,
                    StartDate = Global.CheckIn,
                    EndDate = Global.CheckOut,
                    GuestNum = 0,
                    ChildrenNum = 0,
                    MainGuest = "",
                    Note = ""
                });
            });

            lstRooms.DataSource = Global.BookRooms;
            lstRooms.DisplayMember = "RoomId";
        }

        private void lstRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            detail = orderDetail[lstRooms.SelectedIndex];

            nudGuest.Value = detail.GuestNum;
            nudChildren.Value = detail.ChildrenNum;
            cbBreakfast.Checked = breakfast;
            cbStorage.Checked = storage;
            txtMain.Text = detail.MainGuest;
            txtSpecial.Text = detail.Note;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Guest number exceeded limit
            int num = Convert.ToInt32(nudGuest.Value + nudChildren.Value);
            if (num > detail.Room.RoomSeries.MaximumPerson)
            {
                MessageBox.Show("Guest number exceeded limit", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            detail.GuestNum = Convert.ToInt32(nudGuest.Value);
            detail.ChildrenNum = Convert.ToInt32(nudChildren.Value);
            detail.MainGuest = txtMain.Text;
            detail.Note = txtSpecial.Text;
            breakfast = cbBreakfast.Checked;
            storage = cbStorage.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lstRooms_SelectedIndexChanged(null, null);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Global.lstOrderDetail = orderDetail;
            Global.Breakfast = breakfast;
            Global.Storage = storage;
        }
    }
}

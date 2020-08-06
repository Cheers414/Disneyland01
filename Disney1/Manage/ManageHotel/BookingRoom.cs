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

        List<RoomOrderDetail> lstOrderDetail = new List<RoomOrderDetail>();
        List<bool> lstBreakfast = new List<bool>();
        List<bool> lstStorage = new List<bool>();
        RoomOrderDetail detail;
        bool breakfast;
        bool storage;

        public void DataRefresh()
        {
            guestRecord1.Visible = false;

            lstOrderDetail.Clear();
            Global.BookRooms.ToList().ForEach(x =>
            {
                lstOrderDetail.Add(new RoomOrderDetail
                {
                    Room = x,
                    StartDate = Global.CheckIn,
                    EndDate = Global.CheckOut,
                    GuestNum = 1,
                    ChildrenNum = 0,
                    MainGuest = "",
                    Note = ""
                });
                lstBreakfast.Add(false);
                lstStorage.Add(false);
            });

            lstRooms.DataSource = Global.BookRooms;
            lstRooms.DisplayMember = "RoomId";
        }

        private void lstRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            detail = lstOrderDetail[lstRooms.SelectedIndex];
            breakfast = lstBreakfast[lstRooms.SelectedIndex];
            storage = lstStorage[lstRooms.SelectedIndex];

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
            MessageBox.Show("Save successfully", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lstRooms_SelectedIndexChanged(null, null);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Global.OrderDetails = lstOrderDetail;
            Global.Breakfast = lstBreakfast;
            Global.Storage = lstStorage;
            guestRecord1.DataRefresh();
            guestRecord1.Visible = true;
        }
    }
}

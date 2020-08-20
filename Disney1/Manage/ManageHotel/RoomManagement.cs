using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disney1.Manage.ManageHotel
{
    public partial class RoomManagement : UserControl
    {
        public RoomManagement()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;
        List<Room> lstRoom;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();

            cboStatus.DataSource = db.RoomStatus;
            cboStatus.DisplayMember = "Status";

            cboHotel.DataSource = db.Hotel;
            cboHotel.DisplayMember = "HotelName";


            dgvRoom_SelectionChanged(null, null);
        }

        private void cboHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHotel.SelectedIndex == -1)
            {
                return;
            }

            var hotel = (Hotel)cboHotel.SelectedItem;

            lstRoom = db.Room.ToList().Where(x => x.RoomSeries.SuitesLevel.HotelNo == hotel.HotelNo).ToList();
            dgvRoom.DataSource = lstRoom.Select(x => new
            {
                x.RoomId,
                x.RoomSeries.SuitesLevel.LevelName,
                x.RoomSeries.SuitesName,
                x.RoomSeries.MaximumPerson,
                x.RoomStatus.Status
            }).ToList();
        }

        private void dgvRoom_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count != 1)
            {
                return;
            }

            cboStatus.SelectedIndex = db.RoomStatus.ToList().FindIndex(x => x.RoomStatusNo == lstRoom[dgvRoom.SelectedRows[0].Index].RoomStatusNo);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RoomStatus status = (RoomStatus)cboStatus.SelectedItem;
            lstRoom[dgvRoom.SelectedRows[0].Index].RoomStatus = status;
            db.SubmitChanges();
            MessageBox.Show("Save successfully", "Disneyladn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboHotel_SelectedIndexChanged(null, null);
        }
    }
}

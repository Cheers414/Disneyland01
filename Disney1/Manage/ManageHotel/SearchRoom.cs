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

namespace Disney1.Manage.ManageHotel
{
    public partial class SearchRoom : UserControl
    {
        public SearchRoom()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;
        List<Room> rooms;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();
            cboHotel.DataSource = db.Hotel;
            cboHotel.DisplayMember = "HotelName";
            cboHotel.SelectedIndex = -1;

            lstBook.DataSource = Global.BookRooms;
            lstBook.DisplayMember = "RoomId";

            dtpIn.MinDate = DateTime.Today;
            dtpIn.Value = DateTime.Today;
            //dtpIn_ValueChanged_1(null, null);

            int totalGuest = db.RoomOrderDetail.ToList()
                .Where(x => x.StartDate <= DateTime.Today && x.EndDate >= DateTime.Today)
                .Sum(x => x.GuestNum + x.ChildrenNum);
            lblTotalGuest.Text = $"Total Guest: {totalGuest}";

            dgvStatus.Rows.Clear();
            db.RoomStatus.ToList().ForEach(x =>
            {
                int num = db.Room.ToList().Where(r => r.RoomStatusNo == x.RoomStatusNo).Count();
                dgvStatus.Rows.Add(new object[]
                {
                    x.Status,
                    num
                });
            });
        }

        private void SearchRooms()
        {
            var checkIn = dtpIn.Value;
            var checkOut = dtpOut.Value;
            var hotel = (Hotel)cboHotel.SelectedItem;
            var series = (RoomSeries)cboSeries.SelectedItem;
            var isHigh = cbHigh.Checked;
            var noSide = cbNoSide.Checked;
            var isAdjacent = cbConnecting.Checked;

            //Search empty rooms
            rooms = db.Room.ToList();
            var reservedRooms = db.RoomOrderDetail.ToList()
                .Where(x => Global.TimeIsOverlapping(checkIn, checkOut, x.StartDate, x.EndDate))
                .GroupBy(x => new { x.Room })
                .Select(x => x.Key.Room)
                .ToList();
            rooms = rooms.Except(reservedRooms).ToList();

            //Search room hotel
            if (hotel != null)
            {
                rooms = rooms.Where(x => x.RoomSeries.SuitesLevel.HotelNo == hotel.HotelNo).ToList();
            }

            //Search room series
            if (series != null)
            {
                rooms = rooms.Where(x => x.RoomSeriesNo == series.RoomSeriesNo).ToList();
            }

            //Search high floor rooms
            if (isHigh)
            {
                var highRooms = db.RoomAttributesDetail.ToList().Where(x => x.RoomAttributesNo == 2).Select(x => x.Room).ToList();
                rooms = rooms.Intersect(highRooms).ToList();
            }

            //Search rooms which is not on the edge
            if (noSide)
            {
                var sideRooms = db.RoomAttributesDetail.ToList().Where(x => x.RoomAttributesNo == 1).Select(x => x.Room).ToList();
                rooms = rooms.Except(sideRooms).ToList();
            }

            //Search connecting rooms
            if (isAdjacent)
            {
                List<Room> singleRooms = new List<Room>();
                rooms.ForEach(x =>
                {
                    int hotelId = x.RoomSeries.SuitesLevel.HotelNo;
                    int roomId = Convert.ToInt32(x.RoomId);
                    string lastId = (roomId - 1).ToString().PadLeft(4, '0');
                    string nextId = (roomId + 1).ToString().PadLeft(4,'0');
                    if(!rooms.Any(r=>
                    (r.RoomId == lastId && r.RoomSeries.SuitesLevel.HotelNo == hotelId) || 
                    (r.RoomId == nextId && r.RoomSeries.SuitesLevel.HotelNo == hotelId)))
                    {
                        singleRooms.Add(x);
                    }
                });
                rooms = rooms.Except(singleRooms).ToList();
            }

            dgvRooms.DataSource = rooms.Select(x => new { x.RoomId, x.RoomSeries.SuitesName, x.RoomSeries.MaximumPerson, x.RoomStatus.Status }).ToList();
        }

        private void dtpIn_ValueChanged_1(object sender, EventArgs e)
        {
            dtpOut.MinDate = dtpIn.Value.AddDays(1);
            SearchRooms();
        }
        private void dtpOut_ValueChanged(object sender, EventArgs e)
        {
            SearchRooms();
        }

        private void cboSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchRooms();
        }

        private void cboHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSeries.DataSource = db.RoomSeries.Where(x => x.SuitesLevel.Hotel.HotelNo == ((Hotel)cboHotel.SelectedItem).HotelNo);
            cboSeries.DisplayMember = "SuitesName";
            cboSeries.SelectedIndex = -1;
            SearchRooms();
        }

        private void cbHigh_CheckedChanged(object sender, EventArgs e)
        {
            SearchRooms();
        }

        private void cbNoSide_CheckedChanged(object sender, EventArgs e)
        {
            SearchRooms();
        }

        private void cbAdjacent_CheckedChanged(object sender, EventArgs e)
        {
            SearchRooms();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count != 1)
            {
                return;
            }
            Global.BookRooms.Add(rooms[dgvRooms.SelectedRows[0].Index]);
            SearchRooms();
            rooms = rooms.Except(Global.BookRooms).ToList();
            dgvRooms.DataSource = rooms.Select(x => new { x.RoomId, x.RoomSeries.SuitesName, x.RoomSeries.MaximumPerson, x.RoomStatus.Status }).ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBook.SelectedIndex == -1)
            {
                return;
            }
            Global.BookRooms.RemoveAt(lstBook.SelectedIndex);
            SearchRooms();
            rooms = rooms.Except(Global.BookRooms).ToList();
            dgvRooms.DataSource = rooms.Select(x => new { x.RoomId, x.RoomSeries.SuitesName, x.RoomSeries.MaximumPerson, x.RoomStatus.Status }).ToList();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Disney1.Manage.ManageHotel
{
    public partial class ReserveRoom : UserControl
    {
        public ReserveRoom()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;
        List<Room> lstRooms;
        List<RoomOrderDetail> lstOrderDetail;
        List<bool> lstBreakfast;
        List<bool> lstStorage;
        static List<Guest> lstGuests;
        Ticket ticket = null;
        Coupon coupon = null;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();
            lstRooms = Global.BookRooms.ToList();
            lstOrderDetail = Global.OrderDetails;
            lstBreakfast = Global.Breakfast;
            lstStorage = Global.Storage;
            lstGuests = Global.Guests;

            txtCoupon.Text = "";
            txtTicket.Text = "";

            lblDuring.Text = $"During Residence: {Global.CheckIn.ToString("yyyy/MM/dd")} - {Global.CheckOut.ToString("yyyy/MM/dd")}";
            lblPrice.Text = $"Total Price: ${GetPrice()}";

            //Show order detail
            dgvReservedRoom.DataSource = lstOrderDetail.Select(x => new
            {
                x.Room.RoomId,
                x.GuestNum,
                x.ChildrenNum,
                x.MainGuest
            }).ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                //Add guest
                lstGuests.ForEach(x =>
                {
                    db.Guest.InsertOnSubmit(x);
                });
                db.SubmitChanges();

                //Add order record
                var order = new RoomOrder
                {
                    OrderDateTime = DateTime.Now,
                    GuestNo = Global.OrderGuest.GuestNo,
                    CouponId = coupon == null ? null : coupon.CouponId,
                    TicketId = ticket == null ? null : ticket.TicketId,
                    PaymentMethodNo = null
                };
                db.RoomOrder.InsertOnSubmit(order);
                db.SubmitChanges();

                int i = 0;
                lstOrderDetail.ForEach(x =>
                {
                    //Add order detail
                    x.RoomOrderNo = order.RoomOrderNo;
                    var orderDetail = new RoomOrderDetail()
                    {
                        ChildrenNum = x.ChildrenNum,
                        EndDate = x.EndDate,
                        RoomOrderNo = x.RoomOrderNo,
                        StartDate = x.StartDate,
                        GuestNum = x.GuestNum,
                        MainGuest = x.MainGuest,
                        Note = x.Note,
                        RoomNo = x.RoomNo
                    };
                    db.RoomOrderDetail.InsertOnSubmit(orderDetail);
                    db.SubmitChanges();

                    //Add breakfast
                    if (lstBreakfast[i])
                    {
                        db.RoomServiceRecord.InsertOnSubmit(new RoomServiceRecord
                        {
                            RoomOrderDetailNo = orderDetail.RoomOrderDetailNo,
                            RoomServiceNo = 12,
                            Quantity = orderDetail.GuestNum + orderDetail.ChildrenNum
                        });
                        db.SubmitChanges();
                    }

                    //Add luggage storage service
                    if (lstStorage[i])
                    {
                        db.RoomServiceRecord.InsertOnSubmit(new RoomServiceRecord
                        {
                            RoomOrderDetailNo = orderDetail.RoomOrderDetailNo,
                            RoomServiceNo = 13,
                            Quantity = 1
                        });
                        db.SubmitChanges();
                    }

                    i += 1;
                });

                //Change rooms status
                lstRooms.ForEach(x =>
                {
                    var room = db.Room.ToList().Single(r => r.RoomNo == x.RoomNo);
                    room.RoomStatusNo = 1;
                });
                db.SubmitChanges();

                MessageBox.Show("Reserve successfully", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnReserve.Enabled = false;
                btnBack.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reserve error", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCheckTicket_Click(object sender, EventArgs e)
        {
            //Get ticket
            if (txtTicket.Text != "")
            {
                var t = db.Ticket.ToList().SingleOrDefault(x => x.TicketId == txtTicket.Text);
                if (t != null)
                {
                    ticket = t;
                    lblPrice.Text = $"Total Price: ${GetPrice()}";
                    MessageBox.Show("Ticket ID valid", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Value is empty", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCheckCoupon_Click(object sender, EventArgs e)
        {
            //Get coupon
            if (txtCoupon.Text != "")
            {
                var c = db.Coupon.ToList().SingleOrDefault(x => x.CouponId == txtCoupon.Text);
                if (c != null)
                {
                    coupon = c;
                    lblPrice.Text = $"Total Price: ${GetPrice()}";
                    MessageBox.Show("Coupon ID valid", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Value is empty", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            //Cancel ticket
            ticket = null;
            lblPrice.Text = $"Total Price: ${GetPrice()}";
            txtTicket.Text = "";
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            //Cancel coupon
            coupon = null;
            lblPrice.Text = $"Total Price: ${GetPrice()}";
            txtCoupon.Text = "";
        }

        private int GetPrice()
        {
            //Get price
            int price = lstRooms.Sum(x => x.RoomSeries.Price);
            if (ticket != null)
            {
                price = (int)Math.Ceiling(price * 0.8);
            }
            if (coupon != null)
            {
                price = (int)Math.Ceiling(price * coupon.Discount);
            }
            return price;
        }
    }
}

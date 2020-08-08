using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disney1.Manage.ManageHotel
{
    public partial class HotelService : Form
    {
        public HotelService()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;
        RoomOrderDetail orderDetail;
        List<RoomServiceRecord> lstService;
        RoomServiceRecord serviceRecord;
        int mode = 0;

        private void HotelService_Load(object sender, EventArgs e)
        {
            db = new DisneyDataDataContext();

            cboSerivce.DataSource = db.RoomService;
            cboSerivce.DisplayMember = "ServiceName";

            orderDetail = Global.OrderDetailRecord;
            lstService = db.RoomServiceRecord.ToList().Where(x => x.RoomOrderDetailNo == orderDetail.RoomOrderDetailNo).ToList();
            dgv.DataSource = lstService.Select(x => new
            {
                x.RoomService.ServiceName,
                x.Quantity
            }).ToList();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv.SelectedRows.Count != 1)
            {
                return;
            }
            mode = 0;
            serviceRecord = db.RoomServiceRecord.ToList().Single(x => x.RoomServiceRecordNo == lstService[dgv.SelectedRows[0].Index].RoomServiceRecordNo);
            cboSerivce.SelectedIndex = db.RoomService.ToList().FindIndex(x=>x.RoomServiceNo == serviceRecord.RoomServiceNo);
            nudQty.Value = serviceRecord.Quantity;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.RoomServiceRecord.DeleteOnSubmit(serviceRecord);
            db.SubmitChanges();
            MessageBox.Show("Delete successfully","Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HotelService_Load(null, null);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            mode = 1;
            cboSerivce.SelectedIndex = -1;
            nudQty.Value = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var service = (RoomService)cboSerivce.SelectedItem;
            int qty = (int)nudQty.Value;

            if (mode == 1)
            {
                if(service == null)
                {
                    MessageBox.Show("No select service", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                db.RoomServiceRecord.InsertOnSubmit(new RoomServiceRecord
                {
                    RoomServiceNo = service.RoomServiceNo,
                    RoomOrderDetailNo = orderDetail.RoomOrderDetailNo,
                    Quantity = qty
                });
            }
            else
            {
                serviceRecord.RoomService = service;
                serviceRecord.Quantity = qty;
            }
            db.SubmitChanges();
            MessageBox.Show("Save successfully", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HotelService_Load(null, null);
        }
    }
}

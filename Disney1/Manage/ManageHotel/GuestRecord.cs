using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Disney1.Manage.ManageHotel
{
    public partial class GuestRecord : UserControl
    {
        public GuestRecord()
        {
            InitializeComponent();
        }

        BindingList<Guest> lstGuests = new BindingList<Guest>();
        int mode = 1;
        double temp;

        public void DataRefresh()
        {
            lstGuestName.DataSource = lstGuests;
            lstGuestName.DisplayMember = "Name";

            btnNew_Click(null, null);
        }

        private void lstGuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            mode = 0;
            txtId.Enabled = false;
            var gst = (Guest)lstGuestName.SelectedItem;
            txtName.Text = gst.Name;
            txtId.Text = gst.IdentityNo;
            txtCitizenship.Text = gst.Citizenship;
            txtTemp.Text = gst.Temperature.ToString();
            (gst.Gender == "M" ? rbM : rbF).Checked = true;
            string path = Application.StartupPath + $@"\Images\Guest\{gst.Photo}";
            if (File.Exists(path))
            {
                picGuest.Image = Image.FromFile(path);
            }
            else
            {
                picGuest.Image = null;
            }

            if (Global.OrderGuest != null && gst.IdentityNo == Global.OrderGuest.IdentityNo)
            {
                cbOrderGuest.Checked = true;
            }
            else
            {
                cbOrderGuest.Checked = false;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please input identity number first", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG File|*.jpg";
            ofd.FileName = $"{txtId.Text}.jpg";
            string savePath = Application.StartupPath + $@"\Images\Guest\{ofd.SafeFileName}";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                File.Copy(ofd.FileName, savePath, true);
                picGuest.Image = Image.FromFile(savePath);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (mode != 0)
            {
                return;
            }
            lstGuests.RemoveAt(lstGuestName.SelectedIndex);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            mode = 1;
            cbOrderGuest.Checked = false;
            txtName.Text = "";
            txtId.Text = "";
            txtCitizenship.Text = "";
            txtTemp.Text = "";
            rbM.Checked = true;
            picGuest.Image = null;
            txtId.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (mode != 1)
            {
                return;
            }

            if (!CheckValues())
            {
                return;
            }

            var g = new Guest
            {
                Name = txtName.Text,
                Gender = rbM.Checked ? "M" : "F",
                Photo = txtId.Text + ".jpg",
                IdentityNo = txtId.Text,
                Citizenship = txtCitizenship.Text,
                Temperature = temp,
                isVIP = false,
                RecordDateTime = DateTime.Now
            };
            lstGuests.Add(g);

            if (cbOrderGuest.Checked)
            {
                Global.OrderGuest = g;
            }

            MessageBox.Show("Add successfully", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lstGuest_SelectedIndexChanged(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mode != 0)
            {
                return;
            }

            var gst = (Guest)lstGuestName.SelectedItem;

            if (gst == null)
            {
                return;
            }

            if (!CheckValues())
            {
                return;
            }
            gst.Name = txtName.Text;
            gst.IdentityNo = txtId.Text;
            gst.Gender = rbM.Checked ? "M" : "F";
            gst.Citizenship = txtCitizenship.Text;
            gst.Temperature = temp;

            if (cbOrderGuest.Checked)
            {
                Global.OrderGuest = gst;
            }

            MessageBox.Show("Save successfully", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lstGuest_SelectedIndexChanged(null, null);
        }

        private bool CheckValues()
        {
            if (txtName.Text == "" ||
                txtId.Text == "" ||
                txtCitizenship.Text == "" ||
                txtTemp.Text == "" ||
                picGuest.Image == null)
            {
                MessageBox.Show("Values cannot be empty", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!double.TryParse(txtTemp.Text, out temp))
            {
                MessageBox.Show("Temperature incorrect", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int guestNum = Global.OrderDetails.Sum(x => x.GuestNum + x.ChildrenNum);
            if (lstGuests.Count != guestNum)
            {
                MessageBox.Show($"Guests number incorrcet!\rThere sould be {guestNum} guests", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Global.OrderGuest == null)
            {
                MessageBox.Show($"No order guest", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Global.Guests = lstGuests.ToList();
        }

    }
}

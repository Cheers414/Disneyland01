using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;

namespace Disney1
{
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();
            txtAccount.Text = "";
            txtCitizenship.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtPwd.Text = "";
            DateTime dtNow = DateTime.Now;
            dtpBirthday.MaxDate = dtNow;
            dtpBirthday.Value = dtNow;
            rbMen.Checked = true;
            cboGroup.DataSource = db.Group;
            cboGroup.DisplayMember = "GroupName";
            cboHotel.DataSource = db.Hotel;
            cboHotel.DisplayMember = "HotelName";
            cboHotel.Visible = false;
            lblHotel.Visible = false;
        }

        private void cboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            var group = (Group)cboGroup.SelectedItem;
            if (group.GroupNo == 5 || group.GroupNo == 6)
            {
                lblHotel.Visible = true;
                cboHotel.Visible = true;
            }
            else
            {
                lblHotel.Visible = false;
                cboHotel.Visible = false;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var account = db.Account.FirstOrDefault(x => x.AccountId == txtAccount.Text);
                var group = (Group)cboGroup.SelectedItem;
                var hotel = (Hotel)cboHotel.SelectedItem;

                if (account != null)
                {
                    MessageBox.Show("This account id have been used.", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (txtAccount.Text == "" || txtCitizenship.Text == "" || txtEmail.Text == "" || txtName.Text == "" || txtPwd.Text == "")
                {
                    MessageBox.Show("Values can not be empty.");
                    return;
                }

                if (group.GroupNo == 5 || group.GroupNo == 6)
                {
                    //create hotel manager account
                    db.Account.InsertOnSubmit(new Account()
                    {
                        AccountId = txtAccount.Text,
                        Password = txtPwd.Text,
                        Name = txtName.Text,
                        Birthday = dtpBirthday.Value,
                        Gender = rbMen.Checked ? "M" : "F",
                        Citizenship = txtCitizenship.Text,
                        Email = txtEmail.Text,
                        GroupNo = group.GroupNo,
                        HotelNo = hotel.HotelNo,
                        LastTimeChangePwd = DateTime.Now
                    });
                }
                else
                {
                    //create resort manager or member account
                    db.Account.InsertOnSubmit(new Account()
                    {
                        AccountId = txtAccount.Text,
                        Password = txtPwd.Text,
                        Name = txtName.Text,
                        Birthday = dtpBirthday.Value,
                        Gender = rbMen.Checked ? "M" : "F",
                        Citizenship = txtCitizenship.Text,
                        Email = txtEmail.Text,
                        GroupNo = group.GroupNo,
                        HotelNo = null,
                        LastTimeChangePwd = DateTime.Now
                    });
                }
                db.SubmitChanges();
                MessageBox.Show("Create Accout successfully.", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataRefresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Data incorrcet!", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

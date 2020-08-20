using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disney1
{
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();

            cboGroup.DataSource = db.Group;
            cboGroup.DisplayMember = "GroupName";
            dtpBirthday.MaxDate = DateTime.Today;

            var user = Global.User;
            lblAccount.Text = user.AccountId;
            txtCitizenship.Text = user.Citizenship;
            txtEmail.Text = user.Email;
            txtName.Text = user.Name;
            txtPwd.Text = user.Password;
            dtpBirthday.Value = user.Birthday;
            (user.Gender == "M" ? rbMen : rbFemale).Checked = true;
            cboGroup.SelectedIndex = db.Group.ToList().FindIndex(x => x.GroupNo == user.GroupNo);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DataRefresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var account = db.Account.FirstOrDefault(x => x.AccountId == lblAccount.Text);
                var group = (Group)cboGroup.SelectedItem;

                if (txtCitizenship.Text == "" || txtEmail.Text == "" || txtName.Text == "" || txtPwd.Text == "")
                {
                    MessageBox.Show("Values cannot be empty.");
                    return;
                }

                //Update account
                account.Password = txtPwd.Text;
                account.Name = txtName.Text;
                account.Birthday = dtpBirthday.Value;
                account.Gender = rbMen.Checked ? "M" : "F";
                account.Citizenship = txtCitizenship.Text;
                account.Email = txtEmail.Text;
                account.LastTimeChangePwd = DateTime.Now;
                account.GroupNo = group.GroupNo;
                db.SubmitChanges();
                Global.User = account;
                MessageBox.Show("Save successfully.", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DataRefresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Data incorrcet!", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

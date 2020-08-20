using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disney1
{
    public partial class FrmChangePwd : Form
    {
        public FrmChangePwd()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;

        private void FrmChangePwd_Load(object sender, EventArgs e)
        {
            lblChangeDate.Text = $"Last Time Change your password : {Global.User.LastTimeChangePwd.ToString("dd/MM/yyyy")}\n" +
                $"You should change a new password.";
            lblNowPwd.Text = Global.User.Password;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNewPwd.Text == "")
            {
                MessageBox.Show("Value cannot be empty!", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtNewPwd.Text == lblNowPwd.Text)
            {
                MessageBox.Show("Please change a new password!", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Save password
            db = new DisneyDataDataContext();
            var account = db.Account.ToList().First(x => x.AccountId == Global.User.AccountId);
            account.Password = txtNewPwd.Text;
            account.LastTimeChangePwd = DateTime.Now;
            db.SubmitChanges();
            Global.User = account;
            MessageBox.Show("Change password successfully.", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

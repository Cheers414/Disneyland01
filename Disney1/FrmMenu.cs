﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Disney1
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;
        int errorTimes = 0;
        int lockTime = 10;

        public void DataRefresh()
        {
            Global.User = null;
            gpbLogin.Visible = true;
            txtAccount.Text = "";
            txtPwd.Text = "";
            btnMyData.Visible = false;
            btnHome.Visible = false;
            btnManage.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Search account
            db = new DisneyDataDataContext();
            if (txtAccount.Text == "" || txtPwd.Text == "")
            {
                MessageBox.Show("Account or password can not be empty.", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var user = db.Account.ToList().FirstOrDefault(x => x.AccountId == txtAccount.Text && x.Password == txtPwd.Text);

            //Account or password incorrcet
            if (user == null)
            {
                errorTimes += 1;
                MessageBox.Show("Account or password are not correct.", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (errorTimes >= 3)
                {
                    MessageBox.Show("You entered the account incorrcetly more than 3 times,\n" +
                        "you should wait for 10 second.", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLogin.Enabled = false;
                    timerLock.Start();
                }
                return;
            }

            //Login successfully
            Global.User = user;
            lblUserInfo.Text = $"Welcome {user.Name}\nYou are {user.Group.GroupName}";
            gpbLogin.Visible = false;
            db.LogRecord.InsertOnSubmit(new LogRecord()
            {
                AccountId = user.AccountId,
                LoginTime = DateTime.Now
            });
            db.SubmitChanges();
            MessageBox.Show("Login successfully.", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timerLock_Tick(object sender, EventArgs e)
        {
            lockTime -= 1;
            btnLogin.Text = lockTime.ToString();
            if (lockTime == 0)
            {
                lockTime = 10;
                btnLogin.Enabled = true;
                btnLogin.Text = "Login";
                timerLock.Stop();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DataRefresh();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            signUp1.DataRefresh();
            signUp1.BringToFront();
        }
    }
}
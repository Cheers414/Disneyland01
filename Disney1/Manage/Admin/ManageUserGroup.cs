using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disney1.Manage.Admin
{
    public partial class ManageUserGroup : UserControl
    {
        public ManageUserGroup()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;
        Group group;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();

            cboGroup.DataSource = db.Group;
            cboGroup.DisplayMember = "GroupName";

            lstUser.DataSource = db.Account;
            lstUser.DisplayMember = "Name";
        }

        private void lstUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUser.DataSource == null || cboGroup.DataSource == null)
            {
                return;
            }
            group = db.Account.ToList().Single(x => x.AccountId == ((Account)lstUser.SelectedItem).AccountId).Group;
            cboGroup.SelectedIndex = db.Group.ToList().FindIndex(x => x.GroupNo == group.GroupNo);
        }

        private void cboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUser.DataSource == null || cboGroup.DataSource == null)
            {
                return;
            }
            db = new DisneyDataDataContext();
            var account = db.Account.ToList().Single(x => x.AccountId == ((Account)lstUser.SelectedItem).AccountId);
            account.GroupNo = ((Group)cboGroup.SelectedItem).GroupNo;
            db.SubmitChanges();
        }
    }
}

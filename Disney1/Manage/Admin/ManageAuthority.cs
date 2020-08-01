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
    public partial class ManageAuthority : UserControl
    {
        public ManageAuthority()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;
        AuthorityDetail authority;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();

            lstGroup.DataSource = db.Group;
            lstGroup.DisplayMember = "GroupName";

            lstAuthority.DataSource = db.Authority;
            lstAuthority.DisplayMember = "Event";
        }

        public void GetGroupAuthority()
        {
            if (lstGroup.SelectedItem == null || lstAuthority.SelectedItem == null)
            {
                return;
            }

            authority = db.AuthorityDetail.ToList().Single(x => x.GroupNo == ((Group)lstGroup.SelectedItem).GroupNo && x.AuthorityNo == ((Authority)lstAuthority.SelectedItem).AuthorityNo);
            cbAllow.Checked = authority.isAllow;
        }

        private void lstGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetGroupAuthority();
        }

        private void lstAuthority_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetGroupAuthority();
        }

        private void cbAllow_CheckedChanged(object sender, EventArgs e)
        {
            db.AuthorityDetail.ToList().Single(x => x.AuthorityDetailNo == authority.AuthorityDetailNo).isAllow = cbAllow.Checked;
            db.SubmitChanges();
        }
    }
}

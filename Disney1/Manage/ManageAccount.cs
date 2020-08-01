using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disney1.Manage
{
    public partial class ManageAccount : UserControl
    {
        public ManageAccount()
        {
            InitializeComponent();
        }

        public void DataRefresh()
        {

        }

        private void manageUserGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageGroupAuthorityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageAuthority1.DataRefresh();
            manageAuthority1.BringToFront();
        }
    }
}

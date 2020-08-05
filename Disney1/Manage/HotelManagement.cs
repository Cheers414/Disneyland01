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
    public partial class HotelManagement : UserControl
    {
        public HotelManagement()
        {
            InitializeComponent();
        }

        public void DataRefresh()
        {
            searchRoomToolStripMenuItem_Click(null, null);
        }

        private void searchRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchRoom1.DataRefresh();
            searchRoom1.BringToFront();
        }
    }
}

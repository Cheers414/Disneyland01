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
    public partial class Administrator : UserControl
    {
        public Administrator()
        {
            InitializeComponent();
        }

        public void DataRefresh()
        {
            btnAccount.Visible = true;
            btnHotel.Visible = true;
            btnResort.Visible = true;

            manageAccount1.Visible = false;
            resortManager1.Visible = false;
        }

        private void HideButton()
        {
            btnAccount.Visible = false;
            btnHotel.Visible = false;
            btnResort.Visible = false;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            manageAccount1.DataRefresh();
            manageAccount1.Visible = true;
            HideButton();
        }

        private void btnResort_Click(object sender, EventArgs e)
        {
            resortManager1.DataRefresh();
            resortManager1.Visible = true;
            HideButton();
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            HideButton();
        }
    }
}

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
            HideButton();
            Global.User.Group.AuthorityDetail.ToList().ForEach(x =>
            {
                switch (x.AuthorityNo)
                {
                    case 1:
                        if (x.isAllow)
                        {
                            btnAccount.Visible = true;
                        }
                        break;

                    case 2:
                        if (x.isAllow)
                        {
                            btnResort.Visible = true;
                        }
                        break;

                    case 3:
                        if (x.isAllow)
                        {
                            btnHotel.Visible = true;
                        }
                        break;
                }
            });


            manageAccount1.Visible = false;
            resortManager1.Visible = false;
            hotelManagement1.Visible = false;
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
            hotelManagement1.DataRefresh();
            hotelManagement1.Visible = true;
            HideButton();
        }
    }
}

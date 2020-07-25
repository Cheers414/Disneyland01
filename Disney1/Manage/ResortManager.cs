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
    public partial class ResortManager : UserControl
    {
        public ResortManager()
        {
            InitializeComponent();
        }

        public void DataRefresh()
        {
            showMode1.DataRefresh();
            showMode1.BringToFront();
        }
    }
}

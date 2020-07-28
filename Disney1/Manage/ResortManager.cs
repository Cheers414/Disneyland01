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

        private void attractionsStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attractionsStatistics1.DataRefresh();
            attractionsStatistics1.BringToFront();
        }

        private void setShowModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showMode1.DataRefresh();
            showMode1.BringToFront();
        }

        private void queueTimeStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            queueTimeStatistics1.DataRefresh();
            queueTimeStatistics1.BringToFront();
        }

        private void maintenanceStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintenanceStatistics1.DataRefresh();
            maintenanceStatistics1.BringToFront();
        }
    }
}

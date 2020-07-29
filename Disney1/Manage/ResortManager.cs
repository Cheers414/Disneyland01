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

        private void disneylandResortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disneylandResort1.DataRefresh();
            disneylandResort1.BringToFront();
        }

        private void trafficMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trafficInfo1.DataRefresh();
            trafficInfo1.BringToFront();
        }

        private void tiketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ticketInfo1.DataRefresh();
            ticketInfo1.BringToFront();
        }

        private void attractionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attractionsInfo1.DataRefresh();
            attractionsInfo1.BringToFront();
        }

        private void dramaScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drama1.DataRefresh();
            drama1.BringToFront();
        }

        private void maintenanceScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintenance1.DataRefresh();
            maintenance1.BringToFront();
        }

        private void newsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setNews1.DataRefresh();
            setNews1.BringToFront();
        }

        private void weatherToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void touristToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setTourist1.DataRefresh();
            setTourist1.BringToFront();
        }
    }
}

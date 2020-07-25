using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Disney1.DisneylandResort;
using System.Runtime.InteropServices;

namespace Disney1
{
    public partial class GeneralResort : UserControl
    {
        public GeneralResort()
        {
            InitializeComponent();
        }

        public void DataRefresh()
        {
            disneylandResortToolStripMenuItem_Click(null, null);
        }

        private void disneylandResortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disneylandResort1.DataRefresh();
            disneylandResort1.BringToFront();
        }

        private void newsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            news1.DataRefresh();
            news1.BringToFront();
        }

        private void weatherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            weather1.DataRefresh();
            weather1.BringToFront();
        }

        private void touristStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tourist1.DataRefresh();
            tourist1.BringToFront();
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

        private void attractionScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attractionsSchedule1.DataRefresh();
            attractionsSchedule1.BringToFront();
        }

        private void maintenanceScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintenance1.DataRefresh();
            maintenance1.BringToFront();
        }

        private void GeneralResort_Load(object sender, EventArgs e)
        {
            disneylandResortToolStripMenuItem_Click(null, null);
        }
    }
}

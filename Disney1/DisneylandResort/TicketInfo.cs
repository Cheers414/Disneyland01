using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Disney1.DisneylandResort
{
    public partial class TicketInfo : UserControl
    {
        public TicketInfo()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();
            cboTicket.DataSource = db.TicketOffer;
            cboTicket.DisplayMember = "TicketName";
        }

        private void cboTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ticket = (TicketOffer)cboTicket.SelectedItem;
            lblTicket.Text = $"Price: ${ticket.Price}";
            string path = Application.StartupPath + $@"\Images\Tickets\{ticket.Photo}";
            if (File.Exists(path))
            {
                picTicket.Image = Image.FromFile(path);
            }
            else
            {
                picTicket.Image = null;
            }
        }

        private void TicketInfo_Load(object sender, EventArgs e)
        {

        }
    }
}

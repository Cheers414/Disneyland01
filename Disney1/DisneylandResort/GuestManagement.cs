using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disney1.DisneylandResort
{
    public partial class GuestManagement : UserControl
    {
        public GuestManagement()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();
            dgv.DataSource = db.Guest.Select(x => new
            {
                x.Name,
                x.IdentityNo,
                x.Gender,
                x.Citizenship
            }).ToList();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv.SelectedRows.Count != 1)
            {
                return;
            }

            cbVip.Checked = db.Guest.ToList().ElementAt(dgv.SelectedRows[0].Index).isVIP;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.Guest.ToList().ElementAt(dgv.SelectedRows[0].Index).isVIP = cbVip.Checked;
            db.SubmitChanges();
            MessageBox.Show("Save successfully", "Disneyladn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

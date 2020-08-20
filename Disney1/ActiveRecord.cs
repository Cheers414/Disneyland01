using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disney1
{
    public partial class ActiveRecord : UserControl
    {
        public ActiveRecord()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();
            var active = db.LogRecord.ToList().Where(x => x.AccountId == Global.User.AccountId).Select(x => new { x.LoginTime }).ToList();
            dgv.DataSource = active;
        }
    }
}

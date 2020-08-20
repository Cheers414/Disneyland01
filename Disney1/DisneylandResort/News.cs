using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Disney1.DisneylandResort
{
    public partial class News : UserControl, IKumotoyureiUserControl
    {
        public News()
        {
            InitializeComponent();
        }

        NewsData newsData;

        public void DataRefresh()
        {
            dgv.Visible = true;
            btnBack.Visible = false;
            lblContent.Visible = false;

            string jsonText = File.ReadAllText("NewsData.json");
            newsData = JsonConvert.DeserializeObject<NewsData>(jsonText);

            dgv.DataSource = newsData.NewsList.Select(x => new { x.Title, x.Author, x.PublishedDate }).ToList();
            dgv.Columns[0].FillWeight = 300;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }
            var news = (newsData.NewsList)[e.RowIndex];
            dgv.Visible = false;
            btnBack.Visible = true;
            lblContent.Visible = true;
            lblContent.Text =
                $"{news.Title}\n\n" +
                $"{news.Content}\n\n";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DataRefresh();
        }
    }
}

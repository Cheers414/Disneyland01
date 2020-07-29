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

namespace Disney1.Manage.Manager
{
    public partial class SetNews : UserControl
    {
        public SetNews()
        {
            InitializeComponent();
        }

        NewsData newsData;
        int mode = 1;

        public void DataRefresh()
        {
            string jsonText = File.ReadAllText("NewsData.json");
            newsData = JsonConvert.DeserializeObject<NewsData>(jsonText);
            dgvReset();
        }

        private void dgvReset()
        {
            dgv.DataSource = newsData.NewsList.Select(x => new { x.Title, x.Author }).ToList();
            dgv.Columns[0].FillWeight = 200;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            mode = 0;
            var news = (newsData.NewsList)[e.RowIndex];
            txtTitle.Text = news.Title;
            txtContent.Text = news.Content;
            txtAuthor.Text = news.Author;
            dtpPublished.Value = Convert.ToDateTime(news.PublishedDate);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAuthor.Text == "" || txtContent.Text == "" || txtTitle.Text == "")
            {
                MessageBox.Show("Values can not be empty!", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (mode == 1)
            {
                //Add News
                var lstNews = newsData.NewsList.ToList();
                lstNews.Add(new Newslist
                {
                    Title = txtTitle.Text,
                    Content = txtContent.Text,
                    Author = txtAuthor.Text,
                    PublishedDate = dtpPublished.Value.ToString("yyyy/MM/dd")
                });
                newsData.NewsList = lstNews.ToArray();
            }
            else
            {
                //Edit News
                var news = (newsData.NewsList)[dgv.CurrentCell.RowIndex];
                news.Title = txtTitle.Text;
                news.Content = txtContent.Text;
                news.Author = txtAuthor.Text;
                news.PublishedDate = dtpPublished.Value.ToString("yyyy/MM/dd");
            }

            File.WriteAllText("NewsData.json", JsonConvert.SerializeObject(newsData));
            dgvReset();
            MessageBox.Show("Save successfully.", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = 1;
            txtTitle.Text = "";
            txtContent.Text = "";
            txtAuthor.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            newsData.NewsList.ToList().RemoveAt(dgv.CurrentCell.RowIndex);
        }
    }
}

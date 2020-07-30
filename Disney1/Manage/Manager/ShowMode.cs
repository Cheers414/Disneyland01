using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disney1.Manage.Manager
{
    public partial class ShowMode : UserControl
    {
        public ShowMode()
        {
            InitializeComponent();
        }

        int showMode;
        List<bool> lstCarousel;
        DisneyDataDataContext db;
        bool addMode = false;
        List<CarouselText> lstText;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();

            showMode = Properties.Settings.Default.ShowMode;
            lstCarousel = Properties.Settings.Default.Carousel;
            lstText = db.CarouselText.ToList();

            txtCarouselText.Text = "";

            (showMode == 0 ? rbGeneral : rbCarousel).Checked = true;

            nudStayTime.Value = Properties.Settings.Default.StayTime;

            for (int i = 0; i < lstCarousel.Count; i++)
            {
                if (lstCarousel[i] == false)
                {
                    continue;
                }

                switch (i)
                {
                    case 0:
                        cbDisneylandResort.Checked = true;
                        break;
                    case 1:
                        cbNews.Checked = true;
                        break;
                    case 2:
                        cbWeather.Checked = true;
                        break;
                    case 3:
                        cbTourist.Checked = true;
                        break;
                    case 4:
                        cbAttraction.Checked = true;
                        break;
                    case 5:
                        cbDrama.Checked = true;
                        break;
                    case 6:
                        cbAttractionSchedule.Checked = true;
                        break;
                    case 7:
                        cbMaintenance.Checked = true;
                        break;
                }
            }

            dgvReset();
        }

        private void dgvReset()
        {
            dgv.DataSource = lstText.Select(x => new { x.CarouselText1 }).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.ShowMode = rbGeneral.Checked ? 0 : 1;

                Properties.Settings.Default.StayTime = (int)nudStayTime.Value;

                List<bool> lstCarousel = new List<bool>(new bool[8]);
                for (int i = 0; i < lstCarousel.Count; i++)
                {
                    switch (i)
                    {
                        case 0:
                            lstCarousel[i] = cbDisneylandResort.Checked;
                            break;
                        case 1:
                            lstCarousel[i] = cbNews.Checked;
                            break;
                        case 2:
                            lstCarousel[i] = cbWeather.Checked;
                            break;
                        case 3:
                            lstCarousel[i] = cbTourist.Checked;
                            break;
                        case 4:
                            lstCarousel[i] = cbAttraction.Checked;
                            break;
                        case 5:
                            lstCarousel[i] = cbDrama.Checked;
                            break;
                        case 6:
                            lstCarousel[i] = cbAttractionSchedule.Checked;
                            break;
                        case 7:
                            lstCarousel[i] = cbMaintenance.Checked;
                            break;
                    }
                }
                Properties.Settings.Default.Carousel = lstCarousel;
                Properties.Settings.Default.Save();

                MessageBox.Show("Save successfully!", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataRefresh();
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DataRefresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedCells.Count != 1)
            {
                return;
            }

            var deleteText = db.CarouselText.FirstOrDefault(x => x.CarouselText1 == (string)dgv.SelectedCells[0].Value);
            db.CarouselText.DeleteOnSubmit(deleteText);
            db.SubmitChanges();
            dgv.DataSource = db.CarouselText.Select(x => new { x.CarouselText1 }).ToList();
        }

        private void btnAddText_Click(object sender, EventArgs e)
        {
            txtCarouselText.Text = "";
            addMode = true;
        }

        private void btnSaveText_Click(object sender, EventArgs e)
        {
            if (txtCarouselText.Text == "")
            {
                MessageBox.Show("Value cannot be empty!", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (addMode)
                {
                    //Add carousel text
                    db.CarouselText.InsertOnSubmit(new CarouselText
                    {
                        CarouselText1 = txtCarouselText.Text
                    });
                    txtCarouselText.Text = "";
                }
                else
                {
                    //Edit carousel text
                    lstText[dgv.CurrentCell.RowIndex].CarouselText1 = txtCarouselText.Text;
                }
                db.SubmitChanges();
                lstText = db.CarouselText.ToList();
                dgvReset();
                MessageBox.Show("Save successfully.", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void rbGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGeneral.Checked)
            {
                gbItem.Enabled = false;
                gbText.Enabled = false;
            }
            else
            {
                gbItem.Enabled = true;
                gbText.Enabled = true;
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtCarouselText.Text = lstText[e.RowIndex].CarouselText1;
                addMode = false;
            }
        }
    }
}

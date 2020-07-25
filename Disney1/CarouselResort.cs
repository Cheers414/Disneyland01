using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using Disney1.DisneylandResort;
using System.Threading;
using System.Globalization;

namespace Disney1
{
    public partial class CarouselResort : UserControl
    {
        public CarouselResort()
        {
            InitializeComponent();
        }

        FlowLayoutPanel flowlayout;
        List<bool> lstCarousel = Properties.Settings.Default.Carousel;
        int carouselNum;
        int stayTime = Properties.Settings.Default.StayTime;
        DisneyDataDataContext db;
        Label lblCarousel;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();

            //Set label text
            string cText = "";
            db.CarouselText.ToList().ForEach(x =>
            {
                cText += x.CarouselText1 + "                    ";
            });

            //Create label
            lblCarousel = new Label()
            {
                Location = new Point(1031, 655),
                AutoSize = true,
                Text = cText.Trim()
            };
            this.Controls.Add(lblCarousel);
            timerMove.Start();

            //Create FlowLayoutPanel
            carouselNum = lstCarousel.Count;
            flowlayout = new FlowLayoutPanel()
            {
                Location = new Point(0, 0),
                Size = new Size(1031 * carouselNum, 650),
                AutoScroll = false,
                FlowDirection = FlowDirection.TopDown
            }; ;
            this.Controls.Add(flowlayout);
            CreateCarousel(flowlayout);
            timerStay.Start();
        }

        private void CreateCarousel(FlowLayoutPanel flow)
        {
            //Create Disneyland resort information
            for (int i = 0; i < lstCarousel.Count; i++)
            {
                if (!lstCarousel[i])
                {
                    return;
                }

                switch (i)
                {
                    case 0:
                        DisneylandResort.DisneylandResort disneylandResort = new DisneylandResort.DisneylandResort();
                        flow.Controls.Add(disneylandResort);
                        disneylandResort.DataRefresh();
                        break;

                    case 1:
                        DisneylandResort.News news = new DisneylandResort.News();
                        flow.Controls.Add(news);
                        news.DataRefresh();
                        break;

                    case 2:
                        DisneylandResort.Weather weather = new DisneylandResort.Weather();
                        flow.Controls.Add(weather);
                        weather.DataRefresh();
                        break;

                    case 3:
                        DisneylandResort.Tourist tourist = new Tourist();
                        flow.Controls.Add(tourist);
                        tourist.DataRefresh();
                        break;

                    case 4:
                        DisneylandResort.AttractionsInfo attractionsInfo = new AttractionsInfo();
                        flow.Controls.Add(attractionsInfo);
                        attractionsInfo.DataRefresh();
                        break;

                    case 5:
                        DisneylandResort.Drama drama = new Drama();
                        flow.Controls.Add(drama);
                        drama.DataRefresh();
                        break;

                    case 6:
                        DisneylandResort.AttractionsSchedule attractionsSchedule = new AttractionsSchedule();
                        flow.Controls.Add(attractionsSchedule);
                        attractionsSchedule.DataRefresh();
                        break;

                    case 7:
                        DisneylandResort.Maintenance maintenance = new Maintenance();
                        flow.Controls.Add(maintenance);
                        maintenance.DataRefresh();
                        break;
                }
            }
        }

        private void CarouselResort_Load(object sender, EventArgs e)
        {
            DataRefresh();
        }

        private void CarouselChange()
        {
            //Turn to next carousel
            carouselNum -= 1;
            if (carouselNum == 0)
            {
                flowlayout.Location = new Point(0, 0);
                carouselNum = lstCarousel.Count;
            }
            else
            {
                flowlayout.Left -= 1031;
            }
            timerStay.Start();
        }

        private void timerStay_Tick(object sender, EventArgs e)
        {
            //Stay carousel
            stayTime -= 1;

            if (stayTime == 0)
            {
                stayTime = Properties.Settings.Default.StayTime;
                timerStay.Stop();
                CarouselChange();
            }
        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            //Move label
            lblCarousel.Left -= 1;

            if (lblCarousel.Right == 0)
            {
                lblCarousel.Location = new Point(1031,655);
            }
        }
    }
}

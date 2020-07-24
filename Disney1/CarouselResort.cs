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

namespace Disney1
{
    public partial class CarouselResort : UserControl
    {
        public CarouselResort()
        {
            InitializeComponent();
        }

        List<FlowLayoutPanel> lstFlowLayout;
        List<bool> lstCarousel = Properties.Settings.Default.Carousel;
        int carouselNum = Properties.Settings.Default.Carousel.Count(x => x == true);
        int time = 0;
        int runTimes = 0;

        public void DataRefresh()
        {
            lstFlowLayout = new List<FlowLayoutPanel>();
            lstFlowLayout.Add(new FlowLayoutPanel()
            {
                Location = new Point(0, 0),
                Size = new Size(1031 * carouselNum, 615),
                AutoScroll = false,
                FlowDirection = FlowDirection.TopDown
            });
            this.Controls.Add(lstFlowLayout[0]);
            CreateCarousel(lstFlowLayout[0]);
            timerMove.Start();
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

        private void timerMove_Tick(object sender, EventArgs e)
        {
            lstFlowLayout.First().Left -= 10;
        }
    }
}

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
using System.ComponentModel.Design;

namespace Disney1
{
    public partial class CarouselResort : UserControl
    {
        public CarouselResort()
        {
            InitializeComponent();
        }

        FlowLayoutPanel flowlayout;
        List<bool> lstCarousel;
        int carouselNum;
        int stayTime;
        DisneyDataDataContext db;
        Label lblCarousel;

        public void DataRefresh()
        {
            db = new DisneyDataDataContext();

            lstCarousel = Global.GetCarousel();
            stayTime = Properties.Settings.Default.StayTime;

            this.Controls.Clear();

            //Set label text
            string cText = "";
            db.CarouselText.ToList().ForEach(x =>
            {
                cText += x.CarouselText1 + "                                            ";
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
            carouselNum = lstCarousel.Count(x => x == true);
            flowlayout = new FlowLayoutPanel()
            {
                Location = new Point(0, 0),
                Size = new Size(this.Width * carouselNum, this.Height - 30),
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
            List<UserControl> userControls = new List<UserControl>();
            userControls.Add(new DisneylandResort.DisneylandResort());
            userControls.Add(new News());
            userControls.Add(new Weather());
            userControls.Add(new Tourist());
            userControls.Add(new AttractionsInfo());
            userControls.Add(new Drama());
            userControls.Add(new AttractionsSchedule());
            userControls.Add(new Maintenance());

            userControls.Select((x, y) => new { Control = x, Index = y }).Where(x => lstCarousel[x.Index]).ToList().ForEach(x =>
            {
                flow.Controls.Add(x.Control);
                ((IKumotoyureiUserControl)x.Control).DataRefresh();
            });
        }

        private void CarouselResort_Load(object sender, EventArgs e)
        {

        }

        private void CarouselChange()
        {
            //Turn to next carousel
            carouselNum -= 1;
            if (carouselNum == 0)
            {
                flowlayout.Location = new Point(0, 0);
                carouselNum = lstCarousel.Count(x => x == true);
            }
            else
            {
                flowlayout.Left -= this.Width;
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
                lblCarousel.Location = new Point(1031, 655);
            }
        }
    }
}

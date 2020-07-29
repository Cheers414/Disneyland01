using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disney1
{

    public class TouristData
    {
        public string Total { get; set; }
        public string Current { get; set; }
        public Themeparktourist[] ThemeParkTourist { get; set; }
    }

    public class Themeparktourist
    {
        public string ThemePark { get; set; }
        public string NumberOfTourist { get; set; }
    }

}

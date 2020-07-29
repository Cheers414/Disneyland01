using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disney1
{

    public class NewsData
    {
        public Newslist[] NewsList { get; set; }
    }

    public class Newslist
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string PublishedDate { get; set; }
    }
}

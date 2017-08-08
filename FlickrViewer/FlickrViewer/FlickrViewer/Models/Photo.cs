using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickrViewer.Models
{
    public class Photo
    {
        public string title { get; set; }
        public string link { get; set; }
        public Media media { get; set; }
        public string date_taken { get; set; }
        public string description { get; set; }
        public string published { get; set; }
        public string author { get; set; }
        public string author_id { get; set; }
        public string tags { get; set; }
    }
}

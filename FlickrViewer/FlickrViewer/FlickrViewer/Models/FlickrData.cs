using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickrViewer.Models
{
    public class FlickrData
    {
        public string title { get; set; }
        public string link { get; set; }
        public string description { get; set; }
        public string modified { get; set; }
        public string generator { get; set; }
        public List<Photo> items { get; set; }
    }
}

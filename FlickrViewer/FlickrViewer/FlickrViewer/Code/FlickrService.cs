using FlickrViewer.Interfaces;
using FlickrViewer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FlickrViewer.Code
{
    public class FlickrService : IFlickrService
    {
        public async Task<IEnumerable<Photo>> LoadPhotos(string tags = "")
        {
            var client = new HttpClient();

            string url = "http://api.flickr.com/services/feeds/photos_public.gne?format=json&nojsoncallback=1";
            if (!string.IsNullOrEmpty(tags))
            {
                url += "&tags=" + tags;
            }

            var json = await client.GetStringAsync(url);
            var photos = JsonConvert.DeserializeObject<FlickrData>(json);
            return photos.items;
        }
    }
}

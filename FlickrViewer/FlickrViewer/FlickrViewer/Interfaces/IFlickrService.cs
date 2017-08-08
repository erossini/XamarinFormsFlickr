using FlickrViewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickrViewer.Interfaces
{
    /// <summary>
    /// Interface IFlickrService
    /// </summary>
    public interface IFlickrService
    {
        Task<IEnumerable<Photo>> LoadPhotos(string tags = "");
    }
}

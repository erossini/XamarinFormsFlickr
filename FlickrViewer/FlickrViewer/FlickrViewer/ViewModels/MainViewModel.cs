using FlickrViewer.Interfaces;
using FlickrViewer.Models;
using PSC.Xamarin.MvvmHelpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickrViewer.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Photo> Photos { get; set; }

        public IFlickrService Flickr { get; }

        public MainViewModel(IFlickrService flickr)
        {
            Flickr = flickr;
            Load();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        /// <param name="flickr">The flickr.</param>
        /// <param name="tags">The tags.</param>
        public MainViewModel(IFlickrService flickr, string tags)
        {
            Flickr = flickr;
            Load(tags);
        }

        public async Task Load(string tags = "")
        {
            IEnumerable<Photo> photos = await Flickr.LoadPhotos(tags);
            Photos = new ObservableCollection<Photo>(photos);
            OnPropertyChanged("Photos");
        }
    }
}

using FlickrViewer.Code;
using FlickrViewer.Models;
using FlickrViewer.ViewModels;
using FlickrViewer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FlickrViewer
{
    public partial class MainPage : ContentPage
    {
        MainViewModel vm;
        string tags = "london,united%20kingdom";

        public MainPage()
        {
            InitializeComponent();

            vm = new MainViewModel(new FlickrService(), tags);
            BindingContext = vm;
        }

        void ItemTapped(object sender, ItemTappedEventArgs e)
            => ((ListView)sender).SelectedItem = null;

        void ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var photo = ((ListView)sender).SelectedItem as Photo;
            if (photo == null)
                return;

            var navPage = new NavigationPage(new PhotoDetail(photo));
            Application.Current.MainPage = navPage;
        }
    }
}
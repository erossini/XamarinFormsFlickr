using FlickrViewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlickrViewer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhotoDetail : ContentPage
    {
        public PhotoDetail(Photo photo)
        {
            InitializeComponent();
            BindingContext = photo;
        }

        private void backButton_Clicked(object sender, EventArgs e)
        {
            var navPage = new NavigationPage(new MainPage());
            Application.Current.MainPage = navPage;
        }
    }
}
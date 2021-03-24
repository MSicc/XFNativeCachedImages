using System;
using System.Reflection;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace XfNativeCachedImages
{
    public class ImageViewModel : ObservableObject
    {
        private string _imageUrl;
        private ImageSource _imageFromUrl;

        public ImageViewModel(string imageUrl, string resourceName, Assembly sourceAssembly = null)
        {
            this.ImageUrl = imageUrl;
            this.ImageFromUrl = ImageSource.FromUri(new Uri(this.ImageUrl));
        }


        public string ImageUrl { get => _imageUrl; set => SetProperty(ref _imageUrl, value); }



        public ImageSource ImageFromUrl
        {
            get => _imageFromUrl;
            set
            {
                _imageFromUrl = value;
                OnPropertyChanged(nameof(this.ImageFromUrl));
            }
        }


    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace XfNativeCachedImages
{
    public class MainViewModel : ObservableObject
    {
        private const string _placeholderResource = "CachedImageTest.MSicc_Logo_Base_Blue_1024px_pad25.png";

        private Uri _image1Uri;
        private Uri _image2Uri;
        private ImageSource _image1WithPlaceholderImageSource;

        public MainViewModel()
        {
        }

        public void Init()
        {
            this.Image1Uri = new Uri("https://msicc.net/wp-content/uploads/2020/12/img_7087-scale.jpg");

            this.Image2Uri = new Uri("https://msicc.net/wp-content/uploads/2020/07/ScrollableTabsXF_Title.png");

            this.Image1WithPlaceholderSource = new UriImageSource();

            var imgUrlsFromJson = LoadUrlsFromJson();
            var imgsList = imgUrlsFromJson.Where(u => !string.IsNullOrEmpty(u)).Select(u => new ImageViewModel(u, _placeholderResource)).ToList();

            this.ImagesFromUrl = new ObservableCollection<ImageViewModel>(imgsList);


        }



        private List<string> LoadUrlsFromJson()
        {
            string jsonFileName = "ImageUrls.json";
            var assembly = this.GetType().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");
            using var reader = new StreamReader(stream);
            var jsonString = reader.ReadToEnd();

            return JsonConvert.DeserializeObject<List<string>>(jsonString);
        }



        public string Title => "Cached Image Test with Placeholder";

        public Uri Image1Uri { get => _image1Uri; set => SetProperty(ref _image1Uri, value); }

        public Uri Image2Uri { get => _image2Uri; set => SetProperty(ref _image2Uri, value); }

        public ImageSource Image1WithPlaceholderSource { get => _image1WithPlaceholderImageSource; set => SetProperty(ref _image1WithPlaceholderImageSource, value); }

        public ObservableCollection<ImageViewModel> ImagesFromUrl { get; set; }




    }
}

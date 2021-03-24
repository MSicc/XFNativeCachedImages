using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XfNativeCachedImages
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.SingleImagesTabPage.IconImageSource = new FontImageSource()
            {
                Glyph = XfNativeCachedImages.Resources.MaterialDesignIcons.FileImage,
                FontFamily = "MaterialDesignIcons",
            };

            this.CollectionViewTabpage.IconImageSource = new FontImageSource()
            {
                Glyph = XfNativeCachedImages.Resources.MaterialDesignIcons.FormatListBulleted,
                FontFamily = "MaterialDesignIcons",
            };

            var mainVm = new MainViewModel();
            mainVm.Init();

            this.BindingContext = mainVm;

            
        }
    }
}

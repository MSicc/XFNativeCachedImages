using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Xamarin.Forms;

namespace XfNativeCachedImages.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            AttachNuke();

            return base.FinishedLaunching(app, options);
        }

        private void AttachNuke()
        {
            Xamarin.Forms.Nuke.FormsHandler.Init(true, false);

            //Resource image
            //Xamarin.Forms.Nuke.FormsHandler.PlaceholderFromResource("CachedImageTest.Resources.MSicc_Logo_Base_Blue_1024px_pad25.png", Assembly.GetAssembly(typeof(MainViewModel)));

            //FontImageSource
            Xamarin.Forms.Nuke.FormsHandler.PlaceholderFromFontImageSource(new FontImageSource
            {
                Glyph = XfNativeCachedImages.Resources.MaterialDesignIcons.ImageBroken,
                FontFamily = "MaterialDesignIcons",
                Color = Color.Red
            });
        }
    }
}

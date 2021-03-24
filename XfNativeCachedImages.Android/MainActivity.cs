using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Xamarin.Forms;

namespace XfNativeCachedImages.Droid
{
    [Activity(Label = "XfNativeCachedImages", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            AttachGlide();

            LoadApplication(new App());
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }


        private void AttachGlide()
        {
            Android.Glide.Forms.Init(this, null, false);

            //recommended way of loading resource images=>
            //Android.Glide.Forms.Init(this, new GlideWithAndroidResourcePlaceholder(), false);

            //Xamarin Forms resource image
            //Android.Glide.Forms.PlaceholderFromResource("CachedImageTest.MSicc_Logo_Base_Blue_1024px_pad25.png", Assembly.GetAssembly(typeof(MainViewModel)));

            //FontImageSource
            Android.Glide.Forms.PlaceholderFromFontImageSource(new FontImageSource
            {
                Glyph = XfNativeCachedImages.Resources.MaterialDesignIcons.ImageBroken,
                FontFamily = "MaterialDesignIcons",
                Color = Xamarin.Forms.Color.Red
            });
        }
    }
}
using Android.Glide;
using Android.Widget;
using Bumptech.Glide;
using System.Threading;
using Xamarin.Forms;

namespace XfNativeCachedImages.Droid
{
    public class GlideWithAndroidResourcePlaceholder : IGlideHandler
    {
        public GlideWithAndroidResourcePlaceholder()
        {
        }

        public bool Build(ImageView imageView, ImageSource source, RequestBuilder builder, CancellationToken token)
        {
            if (builder != null)
            {
                //easiest && intended way - add the image to Android resources ....
                //general placeholder:
                //builder.Placeholder(Resource.Drawable.MSicc_Logo_Base_Blue_1024px_pad25).Into(imageView);

                //error placeholder:
                builder.Error(Resource.Drawable.MSicc_Logo_Base_Blue_1024px_pad25).Into(imageView);

                return true;
            }
            else
                return false;
        }
    }

}

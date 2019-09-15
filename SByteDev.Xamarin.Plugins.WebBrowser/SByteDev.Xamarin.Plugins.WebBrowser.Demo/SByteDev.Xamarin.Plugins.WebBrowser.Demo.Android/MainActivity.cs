using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace SByteDev.Xamarin.Plugins.WebBrowser.Demo.Android
{
    [Activity(
        Label = "SByteDev.Xamarin.Plugins.WebBrowser.Demo",
        Theme = "@style/Theme.AppCompat.Light.NoActionBar",
        MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation
    )]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Forms.Init(this, savedInstanceState);

            LoadApplication(new App());
        }
    }
}
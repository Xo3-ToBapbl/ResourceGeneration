using Android.App;
using Android.OS;
using Android.Support.V7.App;

namespace ResourceGeneration.Droid
{
    [Activity(Label = "@string/AppName", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
        }
    }
}
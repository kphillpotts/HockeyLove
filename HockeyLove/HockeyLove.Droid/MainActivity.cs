using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using HockeyApp.Android;
using HockeyApp.Android.Metrics;
using HockeyLove.Constants;

[assembly: MetaData("net.hockeyapp.android.appIdentifier", Value = HockeyappConstants.HockeyAppId_Droid)]
namespace HockeyLove.Droid
{
    [Activity(Label = "HockeyLove", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        const string HOCKEYAPP_ANDROIDAPPID = "be1f933a9d2040bb8e7d2c9a58b63a11";

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            InitializeHockeyApp(HockeyappConstants.HockeyAppId_Droid);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }


        void InitializeHockeyApp(string hockeyAppID)

        {

            CrashManager.Register(this, hockeyAppID);

            //UpdateManager.Register(this, hockeyAppID, true);

            FeedbackManager.Register(this, hockeyAppID, null);

            MetricsManager.Register(Application);

        }
    }
}


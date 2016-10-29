using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using System.Threading.Tasks;
using Xamarin.Forms;
using HockeyApp.Android;



using HockeyLove.Droid.Services;
using HockeyLove.Services;

[assembly: Xamarin.Forms.Dependency(typeof(HockeyappFeedbackService_Android))]
namespace HockeyLove.Droid.Services
{
    public class HockeyappFeedbackService_Android : IHockeyappFeedbackService
    {
        public async Task GiveFeedback()

        {
            FeedbackManager.ShowFeedbackActivity(Forms.Context);
            //await Task.Run(() => FeedbackManager.ShowFeedbackActivity(Forms.Context));

        }
    }

}
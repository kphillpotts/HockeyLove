using HockeyLove.Constants;
using HockeyLove.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HockeyLove
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void FeatureAButton_Clicked(object sender, EventArgs e)
        {
            HockeyApp.MetricsManager.TrackEvent("Feature A");

        }

        private void FeatureBButton_Clicked(object sender, EventArgs e)
        {
            HockeyApp.MetricsManager.TrackEvent("Feature B", new Dictionary<string, string> { { "Message", FeatureBEntry.Text } }, null);

        }

        private void TrackExceptionButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                throw new NotImplementedException("I should really implement this");
            }
            catch (Exception ex)
            {
                HockeyappHelpers.Report(ex);
            }


        }

        private void UnhandledExceptionButton_Clicked(object sender, EventArgs e)
        {
            var y = 0;
            var x = 1 / y;
        }

        private void GiveFeedbackButton_Clicked(object sender, EventArgs e)
        {
            HockeyappHelpers.TrackEvent(HockeyappConstants.FeedbackButtonTapped);
            DependencyService.Get<IHockeyappFeedbackService>()?.GiveFeedback();

        }
    }
}

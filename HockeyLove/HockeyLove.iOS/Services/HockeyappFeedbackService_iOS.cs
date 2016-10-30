﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HockeyApp.iOS;
using HockeyLove.iOS;
using HockeyLove.Services;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(HockeyappFeedbackService_iOS))]
namespace HockeyLove.iOS
{
    public class HockeyappFeedbackService_iOS : IHockeyappFeedbackService
    {
        public async Task GiveFeedback()
        {
            var feedbackManager = BITHockeyManager.SharedHockeyManager.FeedbackManager;

            var alert = UIAlertController.Create("Give Feedback", "Provide Feedback to the Developers", UIAlertControllerStyle.ActionSheet);
            alert.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, null));
            alert.AddAction(UIAlertAction.Create("Review Existing Feedback", UIAlertActionStyle.Default, (obj) => feedbackManager.ShowFeedbackListView()));
            alert.AddAction(UIAlertAction.Create("Submit New Feedback", UIAlertActionStyle.Default, (obj) => feedbackManager.ShowFeedbackComposeView()));

            var window = UIApplication.SharedApplication.KeyWindow;
            var vc = window.RootViewController;
            while (vc.PresentedViewController != null)
            {
                vc = vc.PresentedViewController;
            }

            await vc.PresentViewControllerAsync(alert, true);
        }

        public void TrackEvent(string eventName)
        {
            throw new NotImplementedException();
        }

        public void TrackEvent(string eventName, Dictionary<string, string> properties, Dictionary<string, double> measurements)
        {
            throw new NotImplementedException();
        }
    }
}

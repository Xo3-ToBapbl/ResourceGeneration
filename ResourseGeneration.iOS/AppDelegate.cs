﻿using Foundation;
using ResourseGeneration.iOS.Views;
using UIKit;

namespace ResourseGeneration.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            Window = new UIWindow(UIScreen.MainScreen.Bounds);
            Window.RootViewController = new MainViewController();

            Window.MakeKeyAndVisible();

            return true;
        }
    }
}
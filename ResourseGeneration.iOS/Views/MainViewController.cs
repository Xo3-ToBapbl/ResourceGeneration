using System;
using UIKit;
using Foundation;
using ResourceGeneration.Core.Resources;
using ResourseGeneration.iOS.Extensions;

namespace ResourseGeneration.iOS.Views
{
    [Register("MainViewController")]
    public class MainViewController : UIViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var loginButton = UIButton.FromType(UIButtonType.Plain);
            loginButton.SetTitle(Strings.LoginButtonTitle, UIControlState.Normal);
            loginButton.BackgroundColor = Colors.LightAzure.FromHex();
            loginButton.Font = Dimensions.CommonTextSize.ToUIFont();
            loginButton.SetTitleColor(Colors.DarkViolet.FromHex(), UIControlState.Normal);
            loginButton.TranslatesAutoresizingMaskIntoConstraints = false;

            var titleLabel = new UILabel();
            titleLabel.Text = Strings.ExampleText;
            titleLabel.Font = Dimensions.TitleTextSize.ToUIFont();
            titleLabel.TextAlignment = UITextAlignment.Center;
            titleLabel.TranslatesAutoresizingMaskIntoConstraints = false;

            View.BackgroundColor = Colors.SmokeWhite.FromHex();
            View.AddSubviews(loginButton, titleLabel);

            loginButton.CenterXAnchor.ConstraintEqualTo(View.CenterXAnchor).Active = true;
            loginButton.CenterYAnchor.ConstraintEqualTo(View.CenterYAnchor).Active = true;
            loginButton.WidthAnchor.ConstraintEqualTo(nfloat.Parse(Dimensions.LoginButtonWidth)).Active = true;
            loginButton.HeightAnchor.ConstraintEqualTo(nfloat.Parse(Dimensions.LoginButtonHeight)).Active = true;

            titleLabel.BottomAnchor.ConstraintEqualTo(loginButton.TopAnchor, -20f).Active = true;
            titleLabel.WidthAnchor.ConstraintEqualTo(View.WidthAnchor).Active = true;
        }
    }
}
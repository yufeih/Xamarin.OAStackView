using System;

using UIKit;

using v = OAStackView;

namespace Xamarin.OAStackView.Test
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var stackpanel = new v.OAStackView { 
                Alignment = v.OAStackViewAlignment.Leading,
                Distribution = v.OAStackViewDistribution.Fill,
            };

            stackpanel.AddArrangedSubview(new UIButton(UIButtonType.ContactAdd));
            stackpanel.AddArrangedSubview(new UIButton(UIButtonType.ContactAdd));
            stackpanel.AddArrangedSubview(new UIButton(UIButtonType.ContactAdd));
            stackpanel.AddArrangedSubview(new UIButton(UIButtonType.ContactAdd));
            stackpanel.AddArrangedSubview(new UIButton(UIButtonType.ContactAdd));

            View = stackpanel;

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}


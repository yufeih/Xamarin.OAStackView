using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using v = OAStackView;

namespace Xamarin.OAStackView.Test
{
    partial class MyView : v.OAStackView
	{
		public MyView (IntPtr handle) : base (handle)
		{
            Alignment = v.OAStackViewAlignment.Leading;
            Distribution = v.OAStackViewDistribution.Fill;
		}
	}
}

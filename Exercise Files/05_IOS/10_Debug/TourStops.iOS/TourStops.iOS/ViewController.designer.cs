// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TourStops.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton CalcButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton CallButton1 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton CallButton2 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel DurationMessage { get; set; }

		[Action ("CalcButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void CalcButton_TouchUpInside (UIButton sender);

		[Action ("CallButton1_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void CallButton1_TouchUpInside (UIButton sender);

		[Action ("CallButton2_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void CallButton2_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (CalcButton != null) {
				CalcButton.Dispose ();
				CalcButton = null;
			}
			if (CallButton1 != null) {
				CallButton1.Dispose ();
				CallButton1 = null;
			}
			if (CallButton2 != null) {
				CallButton2.Dispose ();
				CallButton2 = null;
			}
			if (DurationMessage != null) {
				DurationMessage.Dispose ();
				DurationMessage = null;
			}
		}
	}
}

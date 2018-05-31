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
		UILabel DurationMessage { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView TableView1 { get; set; }

		[Action ("CalcButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void CalcButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (CalcButton != null) {
				CalcButton.Dispose ();
				CalcButton = null;
			}
			if (DurationMessage != null) {
				DurationMessage.Dispose ();
				DurationMessage = null;
			}
			if (TableView1 != null) {
				TableView1.Dispose ();
				TableView1 = null;
			}
		}
	}
}

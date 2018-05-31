﻿using System;

using UIKit;

namespace TourStops.iOS
{
	public partial class ViewController : UIViewController
	{
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void CallButton1_TouchUpInside(UIButton sender)
		{
			CallNumber("555-1212");
		}

		partial void CallButton2_TouchUpInside(UIButton sender)
		{
			CallNumber("555-2424");
		}

		partial void CalcButton_TouchUpInside(UIButton sender)
		{
			double duration = CalculateTourDuration(numberOfStops: 2,
																								speedRatio: 1.2);
			DurationMessage.Text = String.Format("{0} minutes", duration);
		}

		private Foundation.NSUrl url;

		private void CallNumber(string phoneNumber)
		{
			url = new Foundation.NSUrl("tel:" + phoneNumber);
			var alert = UIAlertController.Create("Alert", "Simulated call to  " + phoneNumber, UIAlertControllerStyle.Alert);

			alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, MakeCallAction));
			alert.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, null));
			PresentViewController(alert, true, null);

		}

		private void MakeCallAction(UIAlertAction action)
		{
			bool wasSuccessful = UIApplication.SharedApplication.OpenUrl(url);
		}

		private const int TimePerStop = 45; // minutes
		private double CalculateTourDuration(int numberOfStops, double speedRatio)
		{
			// some code for debugging demo

			var temp = numberOfStops;
			var duration = (numberOfStops * TimePerStop) * speedRatio;
			return duration;
		}
	}
}
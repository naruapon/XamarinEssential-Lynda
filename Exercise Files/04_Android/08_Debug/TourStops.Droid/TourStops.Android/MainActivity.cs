using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TourStops.Droid
{
	[Activity(Label = "TourStops.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		//		int count = 1;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button1 = FindViewById<Button>(Resource.Id.calcButton);
			Button button2 = FindViewById<Button>(Resource.Id.callButton2);
			TextView resultText = FindViewById<TextView>(Resource.Id.resultText);
			button1.Click += delegate
			{
				 
				double duration = CalculateTourDuration(numberOfStops: 5,
																								speedRatio: 1.2);
				resultText.Text = String.Format ("{0} minutes" , duration);

			};
			button2.Click += delegate
			{
				CallNumber(button2.Text);
			};
		}

		private const int TimePerStop = 45; // minutes
		private double CalculateTourDuration(int numberOfStops, double speedRatio)
		{
			// some code for debugging demo

			var temp = numberOfStops + 5;
			var duration = (numberOfStops * TimePerStop) *  speedRatio;
			return  duration;
		}
		private void CallNumber(string phoneNumber)
		{
			var callDialog = new AlertDialog.Builder(this);
			callDialog.SetMessage("Call " + phoneNumber);


			callDialog.SetPositiveButton("Call", delegate
			{
				var callIntent = new Intent(Intent.ActionCall);
				callIntent.SetData(Android.Net.Uri.Parse("tel:" + phoneNumber));
				StartActivity(callIntent);
			});
			callDialog.SetNeutralButton("Cancel", delegate { });

			callDialog.Show();
		}
	}
}


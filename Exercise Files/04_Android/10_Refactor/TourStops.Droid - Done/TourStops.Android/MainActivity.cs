using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using TourLib;

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
			var stops = TourLib.TourSource.GetTourStops(6);
			var table = FindViewById<TableLayout>(Resource.Id.tableLayout1);

			foreach (var currentStop in stops)
			{
				var tableRow = new TableRow(this);

				table.AddView(tableRow);

				var textView = new TextView(this);
				textView.Text = currentStop.Name;

				textView.Gravity = GravityFlags.Left;
				tableRow.AddView(textView);



				var mapButton = new Button(this);
				mapButton.Text = "Map";

				// map button click handler goes here...
				mapButton.Click += delegate
				{
					string mapUri = string.Format("geo:0,0?q={0},{1}({2})", currentStop.Latitude, currentStop.Longitude, currentStop.Name);
					var geoUri = Android.Net.Uri.Parse(mapUri);
					var mapIntent = new Intent(Intent.ActionView, geoUri);
					StartActivity(mapIntent);
				};
				mapButton.Gravity = GravityFlags.Right;

				tableRow.AddView(mapButton);

				var button = new Button(this);
				button.Text = currentStop.Phone;

				button.Gravity = GravityFlags.Right;

				// call button click handler goes here...
				button.Click += delegate
				{
					CallNumber(button.Text);
				};

				tableRow.AddView(button);

			}

			#region Calculate Duration    
			// Get our button from the layout resource,
			// and attach an event to it
			Button calcButton = FindViewById<Button>(Resource.Id.calcButton);
			TextView durationText = FindViewById<TextView>(Resource.Id.durationText);
			calcButton.Click += delegate
			{
				var duration = new Duration();
				double result = duration.CalculateTourDuration(numberOfStops: stops.Count,
																								speedRatio: 1.2);
				durationText.Text = String.Format("{0} minutes", result);

			};
			#endregion
		}

		#region Call Number
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
		#endregion


	}
}


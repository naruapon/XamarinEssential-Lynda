using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TourLib
{
	public class Duration
	{
		private const int TimePerStop = 45; // minutes
		public double CalculateTourDuration(int numberOfStops, double speedRatio)
		{
			// some code for debugging demo

			var temp = numberOfStops + 5;
			var duration = (numberOfStops * TimePerStop) * speedRatio;
			return duration;
		}
	}
}
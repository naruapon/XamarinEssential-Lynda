﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NavigationPageExample.Pages {
	public partial class EvenPage : ContentPage {
		public EvenPage() {
			InitializeComponent();
			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < 99; i += 2)
			{
				sb.Append(i.ToString("D2"));
				sb.Append(" ");
			}

			
			MessageLabel.Text = sb.ToString();
		}

		private void Start_Clicked(object sender, EventArgs e) {

			for (int i = 0; i < Navigation.NavigationStack.Count -1; i++)
			{
				// doesn't work for Windows Universal
				Navigation.PopAsync();
				
			}
			
			
			
	
		}
	}
}

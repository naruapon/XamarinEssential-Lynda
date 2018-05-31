using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ShowDataBinding.Pages {
	public partial class WithoutBinding : ContentPage {
		public WithoutBinding() {
			InitializeComponent();

			#region Property set by direct assignment
			Label2.Text = "From a C# String";

			var guide = new Models.Guide();

			guide.GuideName = "Jennie";
			guide.HomeCity = "Miami";
			guide.NumberOfGuidedTours = 67;

			Label2.Text = guide.GuideName;
			#endregion

			

		}
	}

	
}

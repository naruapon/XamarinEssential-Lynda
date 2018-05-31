using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ShowDataBinding.Pages {
	public partial class WithBinding : ContentPage {
		private Models.Guide _guide;
		public WithBinding() {
			InitializeComponent();
			_guide = new Models.Guide();
			_guide.GuideName = "Jennie";
			_guide.HomeCity = "Miami";
			_guide.NumberOfGuidedTours = 67;

			this.BindingContext = _guide;
			
		}
	
	}
}

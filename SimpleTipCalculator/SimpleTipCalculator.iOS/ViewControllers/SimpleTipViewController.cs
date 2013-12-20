using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Intersoft.Crosslight.iOS;
using SimpleTipCalculator.ViewModels;
using Intersoft.Crosslight;

namespace SimpleTipCalculator.iOS
{
	[ImportBinding(typeof(SimpleBindingProvider))]
	[RegisterNavigation(DeviceKind.Phone)]
	public partial class SimpleTipViewController : UIViewController<SimpleViewModel>
	{
		public SimpleTipViewController () 
			: base ("SimpleTipViewController", null)
		{
		}

		protected override void OnViewInitialized ()
		{
			base.OnViewInitialized ();

			this.Title = "Simple Tip Calculator";
		}


		public override bool HideKeyboardOnTap {
			get {
				return true;
			}
		}

	}
}
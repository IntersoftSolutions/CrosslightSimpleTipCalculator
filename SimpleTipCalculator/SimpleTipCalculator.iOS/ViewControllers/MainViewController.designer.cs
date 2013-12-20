// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace SimpleTipCalculator.iOS
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITextField BillTextBox { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton CalculateTipButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField PeopleTextBox { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel TipAmountLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField TipTextBox { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel TotalPaymentLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel TotalPerPersonLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (BillTextBox != null) {
				BillTextBox.Dispose ();
				BillTextBox = null;
			}

			if (TipTextBox != null) {
				TipTextBox.Dispose ();
				TipTextBox = null;
			}

			if (PeopleTextBox != null) {
				PeopleTextBox.Dispose ();
				PeopleTextBox = null;
			}

			if (CalculateTipButton != null) {
				CalculateTipButton.Dispose ();
				CalculateTipButton = null;
			}

			if (TipAmountLabel != null) {
				TipAmountLabel.Dispose ();
				TipAmountLabel = null;
			}

			if (TotalPaymentLabel != null) {
				TotalPaymentLabel.Dispose ();
				TotalPaymentLabel = null;
			}

			if (TotalPerPersonLabel != null) {
				TotalPerPersonLabel.Dispose ();
				TotalPerPersonLabel = null;
			}
		}
	}
}

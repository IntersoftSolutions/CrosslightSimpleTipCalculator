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
	[Register ("SimpleTipViewController")]
	partial class SimpleTipViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton CalculateTipButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel LblPeople { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel LblTip { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel LblTotal { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField TxtBill { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField TxtPeople { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField TxtTip { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TxtBill != null) {
				TxtBill.Dispose ();
				TxtBill = null;
			}

			if (TxtTip != null) {
				TxtTip.Dispose ();
				TxtTip = null;
			}

			if (TxtPeople != null) {
				TxtPeople.Dispose ();
				TxtPeople = null;
			}

			if (CalculateTipButton != null) {
				CalculateTipButton.Dispose ();
				CalculateTipButton = null;
			}

			if (LblTotal != null) {
				LblTotal.Dispose ();
				LblTotal = null;
			}

			if (LblTip != null) {
				LblTip.Dispose ();
				LblTip = null;
			}

			if (LblPeople != null) {
				LblPeople.Dispose ();
				LblPeople = null;
			}
		}
	}
}

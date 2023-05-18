// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace FuturistMac
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField answerLabel { get; set; }

		[Outlet]
		AppKit.NSTextField questionTextField { get; set; }

		[Outlet]
		AppKit.NSTextField titleTextField { get; set; }

		[Action ("Submitted:")]
		partial void Submitted (Foundation.NSObject sender);

		[Action ("submittedButton:")]
		partial void submittedButton (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (answerLabel != null) {
				answerLabel.Dispose ();
				answerLabel = null;
			}

			if (questionTextField != null) {
				questionTextField.Dispose ();
				questionTextField = null;
			}

			if (titleTextField != null) {
				titleTextField.Dispose ();
				titleTextField = null;
			}
		}
	}
}

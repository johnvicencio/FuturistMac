using System;

using AppKit;
using Foundation;
using FuturistMac.Controllers;

namespace FuturistMac
{
	public partial class ViewController : NSViewController
	{
		private PredictionController prediction;

		public ViewController (IntPtr handle) : base (handle)
		{
			prediction = new PredictionController();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// title in the window 
			titleTextField.StringValue = "Reading your future!";
            
        }

        partial void submittedButton(NSObject sender)
        {
            try
            {
                string question = questionTextField.StringValue;

                if (!string.IsNullOrEmpty(question))
                {
                    string answer = prediction.GetRandomAnswer(question);
                    ShowAlert("I predict...", $"{answer}");
                }
                else
                {
                    ShowAlert("Error", "Please enter a question.");
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void ShowAlert(string title, string message)
        {
            NSAlert alert = new NSAlert
            {
                AlertStyle = NSAlertStyle.Informational,
                InformativeText = message,
                MessageText = title
            };

            alert.AddButton("Close");

            int result = (int)alert.RunModal();

            // Handle the close/cancel button action
            if (result == (int)NSAlertButtonReturn.First)
            {
                // Close button clicked
                NSApplication.SharedApplication.StopModal();
            }
        }


        public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}
	}
}

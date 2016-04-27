using System;

using UIKit;

namespace DeepLinkingSample
{
    public partial class ViewController : UIViewController
    {
        protected ViewController (IntPtr handle) : base (handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }

        public void ShowCamera ()
        {
            var cameraPicker = new UIImagePickerController ();
            cameraPicker.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;

            cameraPicker.FinishedPickingImage += (sender, e) => {
                var p = sender as UIImagePickerController;
                DismissViewController (true, () => { });
            };

            cameraPicker.Canceled += (sender, e) => DismissViewController(true, null);

            PresentViewController (cameraPicker, true, () => { });

        }
    }
}


// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace DeepLinkingExampleToday
{
    [Register ("TodayViewController")]
    partial class TodayViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton OpenCameraButton { get; set; }

        [Action ("OpenCameraButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OpenCameraButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (OpenCameraButton != null) {
                OpenCameraButton.Dispose ();
                OpenCameraButton = null;
            }
        }
    }
}
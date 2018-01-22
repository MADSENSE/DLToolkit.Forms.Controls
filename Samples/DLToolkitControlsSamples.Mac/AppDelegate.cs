using AppKit;
using Foundation;
using Xamarin.Forms.Platform.MacOS;
using CoreGraphics;
using Xamarin.Forms;

namespace DLToolkitControlsSamples.Mac
{
    [Register("AppDelegate")]
    public sealed class AppDelegate : FormsApplicationDelegate
    {
        public AppDelegate()
        {
            const NSWindowStyle style = NSWindowStyle.Titled | NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Miniaturizable;

            var rect = new CGRect(200, 200, 1024, 768);
            MainWindow = new NSWindow(rect, style, NSBackingStore.Buffered, false)
            {
                Title = "DLToolkitControlsSamples",
                TitleVisibility = NSWindowTitleVisibility.Hidden
            };
            MainWindow.Center();

            NSApplication.SharedApplication.Menu = new NSMenu();
        }

        public override NSWindow MainWindow { get; }

        public override void DidFinishLaunching(NSNotification notification)
        {
            Forms.Init();
            LoadApplication(new App());
            base.DidFinishLaunching(notification);
        }
    }
}
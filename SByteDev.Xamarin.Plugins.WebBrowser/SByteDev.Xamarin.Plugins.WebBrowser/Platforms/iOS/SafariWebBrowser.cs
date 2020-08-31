using System;
using System.Threading;
using System.Threading.Tasks;
using Foundation;
using SafariServices;
using SByteDev.Xamarin.iOS.Extensions;
using UIKit;

// ReSharper disable once CheckNamespace

namespace SByteDev.Xamarin.Plugins.WebBrowser
{
    [Preserve(AllMembers = true)]
    internal sealed class SafariWebBrowser : SFSafariViewControllerDelegate
    {
        private TaskCompletionSource<object> _taskCompletionSource;
        private SFSafariViewController _safariViewController;

        public Task ShowWebPageAsync(Uri uri, in CancellationToken cancellationToken)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            _taskCompletionSource = new TaskCompletionSource<object>();

            _safariViewController = new SFSafariViewController(new NSUrl(uri.AbsoluteUri))
            {
                ModalPresentationStyle = UIModalPresentationStyle.OverFullScreen,
                Delegate = this
            };

            cancellationToken.ThrowIfCancellationRequested();

            var viewController = UIApplication.SharedApplication.GetTopViewController();

            if (viewController == null)
            {
                _taskCompletionSource.TrySetCanceled();

                return _taskCompletionSource.Task;
            }

            viewController.PresentViewController(_safariViewController, true, null);

            cancellationToken.Register(() =>
            {
                _taskCompletionSource.TrySetCanceled();

                _safariViewController.DismissViewController(true, null);
            });

            return _taskCompletionSource.Task;
        }

        public override void DidFinish(SFSafariViewController controller)
        {
            _taskCompletionSource?.TrySetResult(null);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _taskCompletionSource = null;
                _safariViewController = null;
            }

            base.Dispose(disposing);
        }
    }
}
using System;
using System.Threading;
using System.Threading.Tasks;
using Foundation;

namespace SByteDev.Xamarin.Plugins.WebBrowser
{
    [Preserve(AllMembers = true)]
    public sealed class WebBrowser : NSObject, IWebBrowser
    {
        public Task ShowWebPageAsync(Uri uri, CancellationToken cancellationToken)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            return new SafariWebBrowser().ShowWebPageAsync(uri, cancellationToken);
        }
    }
}
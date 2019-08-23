using System;
using System.Threading;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Support.CustomTabs;
using AndroidUri = Android.Net.Uri;

namespace SByteDev.Xamarin.Plugins.WebBrowser
{
    [Preserve(AllMembers = true)]
    internal sealed class WebBrowser : IWebBrowser
    {
        public Task ShowWebPageAsync(Uri uri, CancellationToken cancellationToken)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            var tabsIntent = new CustomTabsIntent.Builder().Build();

            tabsIntent.Intent.SetFlags(ActivityFlags.ClearTop);
            tabsIntent.Intent.SetFlags(ActivityFlags.NewTask);

            tabsIntent.LaunchUrl(Application.Context, AndroidUri.Parse(uri.AbsoluteUri));

            return Task.CompletedTask;
        }
    }
}
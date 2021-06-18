using System;
using System.Threading;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace

namespace SByteDev.Xamarin.Plugins.WebBrowser
{
    public interface IWebBrowser
    {
        Task ShowWebPageAsync(Uri uri, CancellationToken cancellationToken);
    }
}
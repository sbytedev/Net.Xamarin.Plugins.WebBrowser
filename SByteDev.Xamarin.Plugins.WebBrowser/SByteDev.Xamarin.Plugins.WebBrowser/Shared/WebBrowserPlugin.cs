// ReSharper disable once CheckNamespace

namespace SByteDev.Xamarin.Plugins.WebBrowser
{
    public static class WebBrowserPlugin
    {
        private static readonly Plugin<IWebBrowser> Plugin;

        public static bool IsSupported => Plugin.IsSupported;

        public static IWebBrowser Instance => Plugin.Instance;

        static WebBrowserPlugin()
        {
            Plugin = new Plugin<IWebBrowser>(() => new WebBrowser());
        }
    }
}
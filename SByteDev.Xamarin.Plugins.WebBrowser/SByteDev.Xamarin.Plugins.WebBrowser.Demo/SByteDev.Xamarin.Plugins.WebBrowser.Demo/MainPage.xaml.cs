using System;
using System.Threading;
using Xamarin.Forms;

namespace SByteDev.Xamarin.Plugins.WebBrowser.Demo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void OnButtonClicked(object sender, EventArgs args)
        {
            if (!WebBrowserPlugin.IsSupported)
            {
                return;
            }

            var uri = new Uri("https://github.com");

            await WebBrowserPlugin.Instance.ShowWebPageAsync(uri, CancellationToken.None)
                .ConfigureAwait(false);
        }
    }
}
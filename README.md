# WebBrowser Plugin for Xamarin
![GitHub](https://img.shields.io/github/license/SByteDev/Net.Xamarin.Plugins.WebBrowser.svg)
![Nuget](https://img.shields.io/nuget/v/SByteDev.Xamarin.Plugins.WebBrowser.svg)
[![Build Status](https://img.shields.io/bitrise/07e0cc8ace4a2891/develop?label=development&token=qVt2b6ng_m0VdX6ce0ovKw&branch)](https://app.bitrise.io/app/07e0cc8ace4a2891)
[![Build Status](https://img.shields.io/bitrise/07e0cc8ace4a2891/master?label=production&token=qVt2b6ng_m0VdX6ce0ovKw&branch)](https://app.bitrise.io/app/07e0cc8ace4a2891)
[![CodeFactor](https://www.codefactor.io/repository/github/sbytedev/net.xamarin.plugins.webbrowser/badge)](https://www.codefactor.io/repository/github/sbytedev/net.xamarin.plugins.webbrowser)

Provides a cross-platform UI for displaying the web page.

## Installation
Use [NuGet](https://www.nuget.org) package manager to install this library.

```bash
Install-Package SByteDev.Xamarin.Plugins.WebBrowser
```

## Usage
```cs
using SByteDev.Xamarin.Plugins.WebBrowser;

await WebBrowserPlugin.Instance.ShowWebPageAsync(new Uri("https://github.com"), CancellationToken.None);

```

## Implementation
### iOS
Uses default [SFSafariViewController](https://docs.microsoft.com/en-us/dotnet/api/safariservices.sfsafariviewcontroller).

### Android
Uses [CustomTabsIntent](https://developer.android.com/reference/android/support/customtabs/CustomTabsIntent.html) from [Xamarin.Android.Support.CustomTabs](https://www.nuget.org/packages/Xamarin.Android.Support.CustomTabs/).

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update the tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)

# WebBrowser Plugin for Xamarin
![GitHub](https://img.shields.io/github/license/SByteDev/Net.Xamarin.Plugins.WebBrowser.svg)
![Nuget](https://img.shields.io/nuget/v/SByteDev.Xamarin.Plugins.WebBrowser.svg)

[![Build Status](https://travis-ci.org/SByteDev/Net.Xamarin.Plugins.WebBrowser.svg?branch=master)](https://travis-ci.org/SByteDev/Net.Xamarin.Plugins.WebBrowser)
[![codecov](https://codecov.io/gh/SByteDev/Net.Xamarin.Plugins.WebBrowser/branch/master/graph/badge.svg)](https://codecov.io/gh/SByteDev/Net.Xamarin.Plugins.WebBrowser)
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

await WebBrowserPlugin.ShowWebPageAsync(new Uri("https://github.com"), CancellationToken.None);

```

## Implementation
### iOS
Uses default [SFSafariViewController](https://docs.microsoft.com/en-us/dotnet/api/safariservices.sfsafariviewcontroller).

### Android
Uses [CustomTabsIntent](https://developer.android.com/reference/android/support/customtabs/CustomTabsIntent.html) from [Xamarin.AndroidX.Browser](https://www.nuget.org/packages/Xamarin.AndroidX.Browser/).

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update the tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)